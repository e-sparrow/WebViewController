using System.Collections;
using Birdhouse.Extended.WebView.Interfaces;
using UnityEngine;

namespace Birdhouse.Extended.WebView
{
    [AddComponentMenu("ESparrow/MonoWebViewController")]
    public class MonoWebViewController : MonoBehaviour, IWebViewController
    {
        [SerializeField] private SerializableWebViewInitializationConfig config;
        
        [SerializeField] private bool enableBackButton;
        [SerializeField] private bool canReturnToGame;

        [SerializeField] private WebViewObject webViewObject;

        private IWebViewController _innerController;

        private Coroutine _lifetimeCoroutine;
        private bool _isInitialized = false;
        
        private void Awake()
        {
            _isInitialized = true;
            _innerController = new WebViewController(config, webViewObject);
            
            DontDestroyOnLoad(this);
        }

        public void OpenUrl(string url)
        {
            if (!_isInitialized)
            {
                var message = $@"Trying to open url {url} before initialized controller!";
                throw new WebViewException(message);
            }

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