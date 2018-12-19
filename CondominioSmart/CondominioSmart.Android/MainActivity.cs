using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CondominioSmart.Droid
{
    [Activity(Label = "CondominioSmart",
       Icon = "@mipmap/icon",
       Theme = "@style/MainTheme",
       ScreenOrientation = ScreenOrientation.Portrait)] // Sem rotação de tela
       //ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            


            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Plugin.Iconize.Iconize.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs);
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.MaterialModule());

            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}