#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using DigitalPlatform.Droid.Effects.Entries;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(HideUnderlineEffect), nameof(HideUnderlineEffect))]

namespace DigitalPlatform.Droid.Effects.Entries
{
    class HideUnderlineEffect : PlatformEffect
    {
        #region Methods

        ///<summary>
        ///    Override on attached method.
        ///</summary>
        protected override void OnAttached()
        {
            Control.SetBackgroundColor(Color.Transparent.ToAndroid());
        }

        ///<summary>
        ///    Override on detached method.
        ///</summary>
        protected override void OnDetached()
        {
            Control.SetBackgroundColor(default(Color).ToAndroid());
        }

        #endregion
    }
}