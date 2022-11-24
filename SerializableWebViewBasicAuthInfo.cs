using System;
using Birdhouse.Extended.WebViewController.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebViewController
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