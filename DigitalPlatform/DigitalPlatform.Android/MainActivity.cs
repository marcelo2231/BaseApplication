#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using Prism;
using Prism.Ioc;

namespace DigitalPlatform.Droid
{
    ///<summary>
    ///    Android Main Activity Class.
    ///</summary>
    [Activity(Label = "DigitalPlatform", Icon = "@drawable/logo", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        #region Methods

        ///<summary>
        ///    Overrides OnCreate.
        ///</summary>
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CachedImageRenderer.Init(true);

            var application = new App(new AndroidInitializer());
            await application.StartAsync();

            LoadApplication(application);
        }

        ///<summary>
        ///    Overrides OnRequestPermissionsResult.
        ///</summary>
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        #endregion
    }

    /// <summary>
    ///     Android Initializer.
    /// </summary>
    public class AndroidInitializer : IPlatformInitializer
    {
        #region Methods

        /// <summary>
        ///     Implements base <see cref="RegisterTypes" />.
        /// </summary>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        #endregion
    }
}