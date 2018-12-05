using Android.App;
using Android.Content.PM;
using Android.OS;

namespace CondominioSmart.Droid
{
    [Activity(Label = "CondominioSmart", Icon = "@mipmap/icon", NoHistory = true, Theme = "@style/SplashTheme", 
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
        }
    }
}