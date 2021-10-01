using Android;
using Android.App;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

[assembly: ExportFont("FontAwesome5Regular.otf", Alias = "FA-R")]
[assembly: ExportFont("FontAwesome5Brands.otf", Alias = "FA-B")]
[assembly: ExportFont("FontAwesome5Solid.otf", Alias = "FA-S")]

[assembly: UsesPermission(Manifest.Permission.AccessBackgroundLocation)]
