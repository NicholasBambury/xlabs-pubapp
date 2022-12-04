using xlabs_pubapp.Models;

namespace xlabs_pubapp.Services
{
    public interface IPubService
    {
        PubDetail GetPubDetails(int id);
        List<PubSummary> GetPubSummaries();
        List<PubSummary> GetPubSummariesRating(int minRating);
        List<PubSummary> GetPubSummariesCategory(int category);
    }
}
