using System;
using Birdhouse.Extended.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebView
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