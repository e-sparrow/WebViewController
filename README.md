# WebViewController
WebView handy wrapper to https://github.com/gree/unity-webview solution.

Extension to the Birdhouse repository (https://github.com/e-sparrow/Birdhouse)

How to use it?


## Unity-way
- Add a component `MonoWebViewController` to any object on the scene. Better separate it and add that to a single GameObject.
- You can leave `Web View Object` field null or create new WebViewObject and reference that here.
- Reference just created component in your code and use a method `OpenUrl(string)` of interface `IWebViewController` that's implemented here

That's should look something like this:
```csharp
[SerializeField] private MonoWebViewController webViewController;

...
webViewController.OpenUrl(@"https://google.com");
...
```

## Standard C# classes
In this case, you can do same things, but configuring process will not be as easy and convenient as in unity-way.

- Look at easiest sample:
```csharp
...
// You can leave constructor empty, but if you want add some flexibility and change some parameters,
// look at constructor's declaration
var config = new WebViewInitializationConfig(); 

var controller = new WebViewController(config);
controller.OpenUrl(@"https://google.com");
...
```

- Look at few more flexible samples:
``` csharp
// If you want to change just requestType you can clarify argument's name:
...
var config = new WebViewInitializationConfig(requestType: EWebViewRequestType.UnityWebRequest);
...

// In other case, you can clarify all the values (f.e., if you have some other way to manage that like imGUI/UI...):
...
var hookPattern = new WebViewHookPattern(@"", @"", @".*"); // This hook pattern will hook every link
var authInfo = new WebViewBasicAuthInfo("capybara", "qwerty"); // This auth info is just example
var margins = new WebViewMargins(5, 5, 5, 5, true); // You can clarify margins too. Margins constructor can be empty

var config = new WebViewInitializationConfig
(
    false, 
    false, 
    false, 
    false, 
    false, 
    100, 
    EWebViewRequestType.UnityWebRequest, 
    hookPattern,
    authInfo,
    margins
);
...
```
