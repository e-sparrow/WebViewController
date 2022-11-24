using Birdhouse.Extended.WebViewController.Enums;

namespace Birdhouse.Extended.WebViewController.Interfaces
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