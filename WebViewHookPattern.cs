using Birdhouse.Extended.WebViewController.Interfaces;

namespace Birdhouse.Extended.WebViewController
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