using Microsoft.AspNetCore.Mvc;
using xlabs_pubapp.Models;
using xlabs_pubapp.Services;

namespace xlabs_pubapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PubController : ControllerBase
    {
        private IPubService _pubService;

        public PubController(IPubService pubservice)
        {
            _pubService = pubservice;
        }

        [HttpGet("/GetFullList")]
        public IEnumerable<PubSummary> GetTheFullList()
        {
            return _pubService.GetPubSummaries();
        }

        [HttpGet("/GetOnRating/{minRating}")]
        public IEnumerable<PubSummary> GetRatingList(int minRating)
        {
            return _pubService.GetPubSummariesRating(minRating);
        }

        [HttpGet("/GetOnCategory/{category}")]
        public IEnumerable<PubSummary> GetCategoryList(int category)
        {
            return _pubService.GetPubSummariesCategory(category);
        }

        [HttpGet("/GetPubDetails/{id}")]
        public ActionResult<PubDetail> GetPubDetails(int id)
        {
            return _pubService.GetPubDetails(id);
        }

    }
}
