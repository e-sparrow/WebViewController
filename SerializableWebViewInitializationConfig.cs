using System;
using Birdhouse.Extended.WebView.Enums;
using Birdhouse.Extended.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebView
{
    [Serializable]
    public class SerializableWebViewInitializationConfig : IWebViewInitializationConfig
    {
        [field: SerializeField]
        public bool UseIFrame
        {
            get;
            private set;
        }

        [field: SerializeField]
        public bool AlertDialogEnabled
        {
            get;
            private set;
        }

        [field: SerializeField]
        public bool CameraAccessRequired
        {
            get;
            private set;
        }

        [field: SerializeField]
        public bool MicrophoneAccessRequired
        {
            get;
            private set;
        }

        [field: SerializeField]
        public bool ScrollbarsVisibility
        {
            get;
            private set;
        }

        [field: SerializeField]
        public EWebViewRequestType RequestType
        {
            get;
            private set;
        }

        [field: SerializeField]
        public int TextScale
        {
            get;
            private set;
        } = 100;

        [field: SerializeField]
        public bool HasHookPattern
        {
            get;
            private set;
        }

        [SerializeField] private SerializableWebViewHookPattern hookPattern;
        public IWebViewHookPattern HookPattern => hookPattern;

        [field: SerializeField]
        public bool HasBasicAuthInfo
        {
            get;
            private set;
        }

        [SerializeField] private SerializableWebViewBasicAuthInfo basicAuthInfo;
        public IWebViewBasicAuthInfo BasicAuthInfo => basicAuthInfo;

        [SerializeField] private SerializableWebViewMargins margins;
        public IWebViewMargins Margins => margins;
    }
}