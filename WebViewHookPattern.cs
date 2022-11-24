using Birdhouse.Extended.WebView.Interfaces;

namespace Birdhouse.Extended.WebView
{
    public readonly struct WebViewHookPattern : IWebViewHookPattern
    {
        public WebViewHookPattern(string allow, string deny, string hook)
        {
            Allow = allow;
            Deny = deny;
            Hook = hook;
        }

        public string Allow
        {
            get;
        }

        public string Deny
        {
            get;
        }

        public string Hook
        {
            get;
        }
    }
}