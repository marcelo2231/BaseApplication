#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using FFImageLoading.Svg.Forms;
using FFImageLoading.Transformations;
using FFImageLoading.Work;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DigitalPlatform.Controls
{
    public class TintableImage : SvgCachedImage
    {
        /// <summary>
        ///     Gets/sets image tint color.
        /// </summary>
        public Color TintColor
        {
            get => (Color)GetValue(TintColorProperty);
            set => SetValue(TintColorProperty, value);
        }

        /// <summary>
        ///     <see cref="TintColor"/> bindable property.
        /// </summary>
        public static readonly BindableProperty TintColorProperty =
            BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(TintableImage), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((TintableImage)bindable).updateTintColor());

        /// <summary>
        ///		Updates image tint color.
        /// </summary>
        private void updateTintColor()
        {
            if (TintColor == Color.Transparent)
            {
                Transformations = new List<ITransformation>();
                return;
            }
            var r = (int)(TintColor.R * 255);
            var a = (int)(TintColor.A * 255);
            var b = (int)(TintColor.B * 255);
            var g = (int)(TintColor.G * 255);

            var hex = $"#{a:X2}{r:X2}{g:X2}{b:X2}";

            var transformation = new List<ITransformation>
            {
                new TintTransformation
                {
                    EnableSolidColor = true,
                    HexColor = hex
                }
            };

            Transformations = transformation;
        }
    }
}
