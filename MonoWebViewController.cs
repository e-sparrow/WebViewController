using System.Collections;
using Birdhouse.Extended.WebViewController.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebViewController
{
    [AddComponentMenu("ESparrow/Birdhouse/Extended/WebViewController")]
    public class MonoWebViewController : MonoBehaviour, IWebViewController
    {
        [Header("General")]
        [SerializeField] private SerializableWebViewInitializationConfig config;
        
        [Tooltip("If enabled, you can use device's back button")]
        [SerializeField] private bool enableBackButton;
        [Tooltip("If enabled, you can close the WebView by back button and continue play your application")]
        [SerializeField] private bool canReturnToGame;

        [Header("Start Link")] 
        [Tooltip("Should WebView controller open some link on awake?")]
        [SerializeField] private bool hasStartLink;
        [Tooltip("Link that we gonna open on awake")]
        [SerializeField] private string startLink;

        [Header("References")]
        [SerializeField] private WebViewObject webViewObject;

        private IWebViewController _innerController;

        private Coroutine _lifetimeCoroutine;
        
        private void Awake()
        {
            _innerController = new WebViewController(config, webViewObject);
            if (hasStartLink)
            {
                OpenUrl(startLink);
            }
            
            DontDestroyOnLoad(this);
        }

        public void OpenUrl(string url)
        {
            _innerController.OpenUrl(url);

            if (_lifetimeCoroutine != null)
            {
                StopCoroutine(_lifetimeCoroutine);
            }
            
            _lifetimeCoroutine = StartCoroutine(WebViewLifetimeCoroutine());
        }

        public IWebViewController SetVisibility(bool isVisible)
        {
            _innerController.SetVisibility(isVisible);
            return this;
        }

        public IWebViewController SetPaused(bool isPaused)
        {
            _innerController.SetPaused(isPaused);
            return this;
        }

        public IWebViewController ClearCache(bool includeDiskFiles)
        {
            _innerController.ClearCache(includeDiskFiles);
            return this;
        }

        public IWebViewController ClearCookies()
        {
            _innerController.ClearCookies();
            return this;
        }

        public IWebViewController Reload()
        {
            _innerController.Reload();
            return this;
        }

        public bool GoBack()
        {
            var result = _innerController.GoBack();
            if (result)
            {
                _innerController.GoBack();

                if (canReturnToGame)
                {
                    _innerController.SetVisibility(false);
                }
            }
            
            return result;
        }

        public bool GoForward()
        {
            var result = _innerController.GoForward();
            return result;
        }

        public string GetCookies(string url)
        {
            var result = _innerController.GetCookies(url);
            return result;
        }

        private IEnumerator WebViewLifetimeCoroutine()
        {
            while (Application.isPlaying)
            {
                if (enableBackButton && Input.GetKeyDown(KeyCode.Escape))
                {
                    GoBack();    
                }
                
                yield return null;
            }
        }
        
        public WebViewObject Value => _innerController.Value;
    }
}