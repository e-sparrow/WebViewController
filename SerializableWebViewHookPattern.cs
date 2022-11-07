using System;
using Birdhouse.Features.Wrappers.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Features.Wrappers.WebView
{
    [Serializable]
    public struct SerializableWebViewHookPattern : IWebViewHookPattern
    {
        [field: SerializeField]
        public string Allow
        {
            get;
            private set;
        }

        [field: SerializeField]
        public string Deny
        {
            get;
            private set;
        }

        [field: SerializeField]
        public string Hook
        {
            get;
            private set;
        }
    }
}