namespace Birdhouse.Features.Wrappers.WebView.Interfaces
{
    public interface IWebViewController
    {
        void OpenUrl(string url);

        void GoBack();
        void GoForward();
    }
}