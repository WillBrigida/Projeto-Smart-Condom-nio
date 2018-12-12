using Android.Widget;
using CondominioSmart.Services;
using Xamarin.Forms;
using Application = Android.App.Application;

[assembly: Dependency(typeof(CondominioSmart.Droid.Services.MessageAlert))]

namespace CondominioSmart.Droid.Services
{
    public class MessageAlert : IMessageAlert
    {
        public void LongAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }

        public void ShortAlert(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Short).Show();
        }
    }
}