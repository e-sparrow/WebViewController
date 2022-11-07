using System;
using Birdhouse.Features.Wrappers.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Features.Wrappers.WebView
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