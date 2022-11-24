using System;
using Birdhouse.Extended.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebView
{
    [Serializable]
    public struct SerializableWebViewMargins : IWebViewMargins
    {
        [field: SerializeField]
        public int Left
        {
            get;
            private set;
        }

        [field: SerializeField]
        public int Top
        {
            get;
            private set;
        }

        [field: SerializeField]
        public int Right
        {
            get;
            private set;
        }

        [field: SerializeField]
        public int Bottom
        {
            get;
            private set;
        }

        [field: SerializeField]
        public bool IsRelative
        {
            get;
            private set;
        }
    }
}