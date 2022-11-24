using System;
using Birdhouse.Extended.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebView
{
    [Serializable]
    public struct SerializableWebViewBasicAuthInfo : IWebViewBasicAuthInfo
    {
        [field: SerializeField]
        public string Id
        {
            get;
            private set;
        }

        [field: SerializeField]
        public string Password
        {
            get;
            private set;
        }
    }
}