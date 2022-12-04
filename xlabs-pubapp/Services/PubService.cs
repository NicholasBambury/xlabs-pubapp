using xlabs_pubapp.Models;

namespace xlabs_pubapp.Services
{
    public class PubService : IPubService
    {
        private readonly ILogger<PubService> _logger;
        private PubDataContext _pubDataContext;
        public PubService(ILogger<PubService> logger, PubDataContext pubDataContext) 
        {
            _logger = logger;
            _pubDataContext = pubDataContext;
        }

        public PubDetail GetPubDetails(int id)
        {
            _logger.LogInformation($"GetPub Details for {id}");

            var pubdetail = _pubDataContext.Details.FirstOrDefault(d => d.Id == id);

            if(pubdetail == null) 
            {
                throw new ArgumentException($"Pub details for {id} Not Found");
            }
            return pubdetail;
        }

        public List<PubSummary> GetPubSummaries()
        {
            var pubSummaries = _pubDataContext.Details.Select(pd => new PubSummary
            {
                Id = pd.Id,
                Name = pd.Name,
                Rating = ((pd.StarsBeer + pd.StarsAmnities + pd.StarsAtmosphere + pd.StarsValue) / 4)
            }).ToList();
            return pubSummaries;
        }

        public List<PubSummary> GetPubSummariesCategory(int category)
        {

            var pubSummaries = _pubDataContext.Details.Where(d => d.Category == (Category)category).Select(pd => new PubSummary
            {
                Id = pd.Id,
                Name = pd.Name,
                Rating = ((pd.StarsBeer + pd.StarsAmnities + pd.StarsAtmosphere + pd.StarsValue) / 4)
            }).ToList();
            return pubSummaries;
        }

        public List<PubSummary> GetPubSummariesRating(int minRating)
        {
            var pubSummaries = _pubDataContext.Details.Select(pd => new PubSummary
            {
                Id = pd.Id,
                Name = pd.Name,
                Rating = ((pd.StarsBeer + pd.StarsAmnities + pd.StarsAtmosphere + pd.StarsValue) / 4)
            }).ToList();

            return pubSummaries.Where(ps => ps.Rating >= minRating).ToList(); ;
        }
    }
}
