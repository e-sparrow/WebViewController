using Birdhouse.Extended.WebView.Enums;
using Birdhouse.Extended.WebView.Interfaces;

namespace Birdhouse.Extended.WebView
{
    public readonly struct WebViewInitializationConfig : IWebViewInitializationConfig
    {
        public WebViewInitializationConfig
        (
            bool useIFrame = false, 
            bool alertDialogEnabled = false, 
            bool cameraAccessRequired = false,
            bool microphoneAccessRequired = false,
            bool scrollbarsVisibility = false,
            int textScale = 100, 
            EWebViewRequestType requestType = EWebViewRequestType.UnityWebRequest, 
            
            IWebViewHookPattern hookPattern = null, 
            IWebViewBasicAuthInfo basicAuthInfo = null, 
            IWebViewMargins margins = null
        )
        {
            UseIFrame = useIFrame;
            AlertDialogEnabled = alertDialogEnabled;
            CameraAccessRequired = cameraAccessRequired;
            MicrophoneAccessRequired = microphoneAccessRequired;
            ScrollbarsVisibility = scrollbarsVisibility;
            TextScale = textScale;
            RequestType = requestType;

            HasHookPattern = hookPattern != null;
            HookPattern = hookPattern;
            
            HasBasicAuthInfo = basicAuthInfo != null;
            BasicAuthInfo = basicAuthInfo;
            
            Margins = margins ?? new WebViewMargins();
        }

        public bool UseIFrame
        {
            get;
        }

        public bool AlertDialogEnabled
        {
            get;
        }

        public bool CameraAccessRequired
        {
            get;
        }

        public bool MicrophoneAccessRequired
        {
            get;
        }

        public bool ScrollbarsVisibility
        {
            get;
        }

        public EWebViewRequestType RequestType
        {
            get;
        }

        public int TextScale
        {
            get;
        }

        public bool HasHookPattern
        {
            get;
        }

        public IWebViewHookPattern HookPattern
        {
            get;
        }

        public bool HasBasicAuthInfo
        {
            get;
        }

        public IWebViewBasicAuthInfo BasicAuthInfo
        {
            get;
        }

        public IWebViewMargins Margins
        {
            get;
        }
    }
}