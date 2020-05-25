#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using FFImageLoading.Forms.Platform;
using Foundation;
using Prism;
using Prism.Ioc;
using System.Threading.Tasks;
using UIKit;

namespace DigitalPlatform.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            loadApplicationAsync().Wait();

            return base.FinishedLaunching(app, options);
        }

        /// <summary>
        ///     Loads the application async.
        /// </summary>
        private async Task loadApplicationAsync()
        {
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

            var application = new App(new iOSInitializer());
            await application.StartAsync().ConfigureAwait(false);

            LoadApplication(application);
        }
    }

    /// <summary>
    ///     iOS Initializer.
    /// </summary>
    public class iOSInitializer : IPlatformInitializer
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
