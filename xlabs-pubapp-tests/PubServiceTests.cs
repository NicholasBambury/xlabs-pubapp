using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;
using xlabs_pubapp.Models;
using xlabs_pubapp.Services;
using Xunit;

namespace xlabs_pubapp_tests
{
    public class PubServiceTests
    {
        private readonly IPubService _pubService;
        private readonly ILogger<PubService> _log;
        private readonly PubDataContext contextMemory;

        public PubServiceTests() 
        {
            _log = Substitute.For<ILogger<PubService>>();

            contextMemory = CreateDbContext();

            _pubService = new PubService(_log, contextMemory);            
        }

        private PubDataContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<PubDataContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            var dbContext = new PubDataContext(options);
            return SeedData.Initialize(dbContext);
        }
        
        [Fact]
        public void GetPubDetails_LogsParameterDetails()
        {
            var pubId = 1;
            _pubService.GetPubDetails(pubId);
            _log.Received().LogInformation($"GetPub Details for {pubId}");
        }

        [Fact]
        public void GetPubDetails_ReturnsPubDetail()
        {
            var details = _pubService.GetPubDetails(1);
            Assert.NotNull(details);
            Assert.Equal("Golf Cafe Bar", details.Name);
        }

        [Fact]
        public void GetPubDetails_ThrowsNotFoundException()
        {
            Assert.Throws<ArgumentException>(() => _pubService.GetPubDetails(0));

        }
    }
}