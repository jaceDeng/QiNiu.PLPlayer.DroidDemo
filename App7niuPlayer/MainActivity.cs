using Android.App;
using Android.Widget;
using Android.OS;
using Com.Pili.Pldroid.Player.Widget;

namespace App7niuPlayer
{
    [Activity(Label = "视频直播", MainLauncher = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation,
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape,
        Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Quanp
            RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);// 隐藏标题

            Window.SetFlags(Android.Views.WindowManagerFlags.Fullscreen, Android.Views.WindowManagerFlags.Fullscreen);// 设置全屏 
            SetContentView(Resource.Layout.Main);
            PLVideoView mVideoView = FindViewById<PLVideoView>(Resource.Id.PLVideoView);
            mVideoView.SetVideoPath("rtmp://live.hkstv.hk.lxdns.com/live/hks");

        }
    }
}

