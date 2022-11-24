using System;
using Birdhouse.Extended.WebViewController.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebViewController
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