# Android Things Binding for Xamarin.Android

Build connected devices for a wide variety of consumer, retail, and industrial applications

[Android Things - More Information](https://developer.android.com/things/index.html)


## Getting Started

### Declare a home activity
An application running on an embedded device must declare an activity in its manifest as the main entry point after the device boots.  You can do this by adding the following attributes to your main activity:

```sharp
[Activity(Label = "Sample Thing")]
[IntentFilter (new[] { Intent.ActionMain }, Categories = new[] { Intent.CategoryLauncher })]
[IntentFilter(new[] { Intent.ActionMain }, Categories = new[] { "android.intent.category.IOT_LAUNCHER" })]
public class MainActivity : Activity
{
    // ...
}
```


### More SDK Information

For more information about the Android Things SDK, visit the [Official Android Things SDK Developer Site](https://developer.android.com/things/sdk/index.html).