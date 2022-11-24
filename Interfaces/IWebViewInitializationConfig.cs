using Birdhouse.Extended.WebView.Enums;

namespace Birdhouse.Extended.WebView.Interfaces
{
    public interface IWebViewInitializationConfig
    {
        bool UseIFrame
        {
            get;
        }

        bool AlertDialogEnabled
        {
            get;
        }

        bool CameraAccessRequired
        {
            get;
        }

        bool MicrophoneAccessRequired
        {
            get;
        }

        bool ScrollbarsVisibility
        {
            get;
        }

        EWebViewRequestType RequestType
        {
            get;
        }
        
        int TextScale
        {
            get;
        }

        bool HasHookPattern
        {
            get;
        }

        IWebViewHookPattern HookPattern
        {
            get;
        }

        bool HasBasicAuthInfo
        {
            get;
        }

        IWebViewBasicAuthInfo BasicAuthInfo
        {
            get;
        }

        IWebViewMargins Margins
        {
            get;
        }
    }
}