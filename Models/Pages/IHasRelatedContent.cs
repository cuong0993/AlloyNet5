using EPiServer.Core;

namespace AllloyNet5.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
