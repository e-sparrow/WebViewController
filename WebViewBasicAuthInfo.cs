using Birdhouse.Features.Wrappers.WebView.Interfaces;

namespace Birdhouse.Features.Wrappers.WebView
{
    public readonly struct WebViewBasicAuthInfo : IWebViewBasicAuthInfo
    {
        public WebViewBasicAuthInfo(string id, string password)
        {
            Id = id;
            Password = password;
        }
        
        public string Id
        {
            get;
        }

        public string Password
        {
            get;
        }
    }
}