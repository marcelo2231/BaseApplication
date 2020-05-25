#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Android.Graphics;
using Android.Widget;
using System;
using DigitalPlatform.Droid.Effects.Labels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName(DigitalPlatform.Effects.EffectsGroupName.ResolutionGroupName)]
[assembly: ExportEffect(typeof(UnderlineEffect), nameof(UnderlineEffect))]

namespace DigitalPlatform.Droid.Effects.Labels
{
    public class UnderlineEffect : PlatformEffect
    {
        #region Methods

        ///<summary>
        ///    Override on attached method.
        ///</summary>
        protected override void OnAttached()
        {
            setUnderline(true);
        }

        ///<summary>
        ///    Override on detached method.
        ///</summary>
        protected override void OnDetached()
        {
            setUnderline(false);
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName == Label.TextProperty.PropertyName ||
                args.PropertyName == Label.FormattedTextProperty.PropertyName)
            {
                setUnderline(true);
            }
        }

        private void setUnderline(bool underlined)
        {
            try
            {
                var textView = (TextView)Control;
                if (underlined)
                {
                    textView.PaintFlags |= PaintFlags.UnderlineText;
                }
                else
                {
                    textView.PaintFlags &= ~PaintFlags.UnderlineText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion
    }
}