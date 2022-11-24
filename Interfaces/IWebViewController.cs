namespace Birdhouse.Extended.WebView.Interfaces
{
    public interface IWebViewController
    {
        void OpenUrl(string url);

        IWebViewController SetVisibility(bool isVisible);
        IWebViewController SetPaused(bool isPaused);
        IWebViewController ClearCache(bool includeDiskFiles);
        IWebViewController ClearCookies();
        IWebViewController Reload();
        
        bool GoBack();
        bool GoForward();

        string GetCookies(string url);

        WebViewObject Value
        {
            get;
        }
    }
}