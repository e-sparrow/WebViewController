namespace Birdhouse.Features.Wrappers.WebView.Interfaces
{
    public interface IWebViewHookPattern
    {
        string Allow
        {
            get;
        }

        string Deny
        {
            get;
        }

        string Hook
        {
            get;
        }
    }
}