using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Media;

namespace Experiment
{
    [Activity
        (Label = "@string/app_name", 
        Theme = "@style/MyTheme" )]
     
    
    public class MainActivity : Activity
    {
        MediaPlayer player;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
           
            SetContentView(Resource.Layout.activity_main);

            player = MediaPlayer.Create(this, Resource.Raw.Stay);
            
            MediaRouteButton button= FindViewById<MediaRouteButton>(Resource.Id.button1);
            button.Click += (sender, e) =>
            {
                player.Start();
            };
        }
    }
    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
}