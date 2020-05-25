#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalPlatform.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckboxLabelControl
    {
        #region Properties

        ///<summary>
        ///    Gets/sets checked image source.
        ///</summary>
        public string CheckedImage
        {
            get => (string)GetValue(CheckedImageProperty);
            set => SetValue(CheckedImageProperty, value);
        }


        ///<summary>
        ///    Gets/sets unchecked image source.
        ///</summary>
        public string UncheckedImage
        {
            get => (string)GetValue(UncheckedImageProperty);
            set => SetValue(UncheckedImageProperty, value);
        }


        ///<summary>
        ///    Gets/sets image aspect.
        ///</summary>
        public Aspect Aspect
        {
            get => (Aspect)GetValue(AspectProperty);
            set => SetValue(AspectProperty, value);
        }

        ///<summary>
        ///    Gets/sets image width.
        ///</summary>
        public double ImageWidth
        {
            get => (double)GetValue(ImageWidthProperty);
            set => SetValue(ImageWidthProperty, value);
        }

        ///<summary>
        ///    Gets/sets image height.
        ///</summary>
        public double ImageHeight
        {
            get => (double)GetValue(ImageHeightProperty);
            set => SetValue(ImageHeightProperty, value);
        }

        /// <summary>
        ///     Gets/sets is checked.
        /// </summary>
        public Boolean IsChecked
        {
            get => (Boolean)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        /// <summary>
        ///     Gets/sets image tint color.
        /// </summary>
        public Color TintColor
        {
            get => (Color)GetValue(TintColorProperty);
            set => SetValue(TintColorProperty, value);
        }


        ///<summary>
        ///    Gets/sets label font attributes.
        ///</summary>
        public FontAttributes FontAttributes
        {
            get => (FontAttributes)GetValue(FontAttributesProperty);
            set => SetValue(FontAttributesProperty, value);
        }

        ///<summary>
        ///    Gets/sets label font family.
        ///</summary>
        public string FontFamily
        {
            get => (string)GetValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }

        ///<summary>
        ///    Gets/sets label font size.
        ///</summary>
        public double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        ///<summary>
        ///    Gets/sets label formatted text.
        ///</summary>
        public FormattedString FormattedText
        {
            get => (FormattedString)GetValue(FormattedTextProperty);
            set => SetValue(FormattedTextProperty, value);
        }

        ///<summary>
        ///    Gets/sets label horizontal text alignment.
        ///</summary>
        public TextAlignment HorizontalTextAlignment
        {
            get => (TextAlignment)GetValue(HorizontalTextAlignmentProperty);
            set => SetValue(HorizontalTextAlignmentProperty, value);
        }

        ///<summary>
        ///    Gets/sets label line break mode.
        ///</summary>
        public LineBreakMode LineBreakMode
        {
            get => (LineBreakMode)GetValue(LineBreakModeProperty);
            set => SetValue(LineBreakModeProperty, value);
        }

        ///<summary>
        ///    Gets/sets label text.
        ///</summary>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        ///<summary>
        ///    Gets/sets label text color.
        ///</summary>
        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        ///<summary>
        ///    Gets/sets label vertical text alignment.
        ///</summary>
        public TextAlignment VerticalTextAlignment
        {
            get => (TextAlignment)GetValue(VerticalTextAlignmentProperty);
            set => SetValue(VerticalTextAlignmentProperty, value);
        }

        #endregion

        #region Bindable Properties

        ///<summary>
        ///    Image aspect bindable property.
        ///</summary>
        public static readonly BindableProperty AspectProperty =
            BindableProperty.Create(nameof(Aspect), typeof(Aspect), typeof(CheckboxLabelControl), default(Aspect),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateImgAspect());

        /// <summary>
        ///     <see cref="CheckedImage" /> bindable property.
        /// </summary>
        public static readonly BindableProperty CheckedImageProperty =
            BindableProperty.Create(nameof(CheckedImage), typeof(string), typeof(CheckboxLabelControl), "checked.svg",
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateImage());

        ///<summary>
        ///    Label font attributes bindable property.
        ///</summary>
        public static readonly BindableProperty FontAttributesProperty =
            BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(CheckboxLabelControl),
                default(FontAttributes),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblFontAttributes());

        ///<summary>
        ///    Label font family bindable property.
        ///</summary>
        public static readonly BindableProperty FontFamilyProperty =
            BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(CheckboxLabelControl), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblFontFamily());

        ///<summary>
        ///    Label font size bindable property.
        ///</summary>
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CheckboxLabelControl), 14D,
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblFontSize());

        ///<summary>
        ///    Label formatted text bindable property.
        ///</summary>
        public static readonly BindableProperty FormattedTextProperty =
            BindableProperty.Create(nameof(FormattedText), typeof(FormattedString), typeof(CheckboxLabelControl),
                default(FormattedString),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblFormattedText());

        ///<summary>
        ///    Label horizontal text alignment bindable property.
        ///</summary>
        public static readonly BindableProperty HorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(HorizontalTextAlignment), typeof(TextAlignment),
                typeof(CheckboxLabelControl),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblHorizontalTextAlignment());

        ///<summary>
        ///    Image height bindable property.
        ///</summary>
        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create(nameof(ImageHeight), typeof(double), typeof(CheckboxLabelControl), 30D,
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateImgHeight());

        ///<summary>
        ///    Image width bindable property.
        ///</summary>
        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create(nameof(ImageWidth), typeof(double), typeof(CheckboxLabelControl), 30D,
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateImgWidth());

        /// <summary>
        ///     <see cref="IsChecked" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsCheckedProperty =
            BindableProperty.Create(nameof(IsChecked), typeof(Boolean), typeof(CheckboxLabelControl), false);

        ///<summary>
        ///    Label line break mode bindable property.
        ///</summary>
        public static readonly BindableProperty LineBreakModeProperty =
            BindableProperty.Create(nameof(LineBreakMode), typeof(LineBreakMode), typeof(CheckboxLabelControl),
                default(LineBreakMode),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblLineBreakMode());

        ///<summary>
        ///    Label text color bindable property.
        ///</summary>
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CheckboxLabelControl), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblTextColor());

        ///<summary>
        ///    Label text bindable property.
        ///</summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CheckboxLabelControl), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblText());

        /// <summary>
        ///     <see cref="TintColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TintColorProperty =
            BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(CheckboxLabelControl), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateTintColor());

        /// <summary>
        ///     <see cref="UncheckedImage" /> bindable property.
        /// </summary>
        public static readonly BindableProperty UncheckedImageProperty =
            BindableProperty.Create(nameof(UncheckedImage), typeof(string), typeof(CheckboxLabelControl),
                "unchecked.svg",
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateImage());

        ///<summary>
        ///    Label vertical text alignment bindable property.
        ///</summary>
        public static readonly BindableProperty VerticalTextAlignmentProperty =
            BindableProperty.Create(nameof(VerticalTextAlignment), typeof(TextAlignment), typeof(CheckboxLabelControl),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CheckboxLabelControl)bindable).updateLblVerticalTextAlignment());

        #endregion

        #region Methods

        #region Constructors

        ///<summary>
        ///    Default Constructor.
        ///</summary>
        public CheckboxLabelControl()
        {
            InitializeComponent();
            updateImage();
        }

        #endregion

        ///<summary>
        ///    Updates image aspect.
        ///</summary>
        private void updateImgAspect()
        {
            CheckBoxImage.Aspect = Aspect;
        }

        ///<summary>
        ///    Updates image width.
        ///</summary>
        private void updateImgWidth()
        {
            CheckBoxImage.WidthRequest = ImageWidth;
        }

        ///<summary>
        ///    Updates image height.
        ///</summary>
        private void updateImgHeight()
        {
            CheckBoxImage.HeightRequest = ImageHeight;
        }


        ///<summary>
        ///    Updates image.
        ///</summary>
        private void updateImage()
        {
            if (IsChecked)
            {
                CheckBoxImage.Source = CheckedImage;
            }
            else
            {
                CheckBoxImage.Source = UncheckedImage;
            }
        }

        /// <summary>
        ///     Tap gesture recognizer on tapped method that updates the <see cref="IsChecked" /> property.
        /// </summary>
        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
            updateImage();
        }

        /// <summary>
        ///     Updates image tint color.
        /// </summary>
        private void updateTintColor()
        {
            CheckBoxImage.TintColor = TintColor;
        }

        ///<summary>
        ///    Updates label font attributes.
        ///</summary>
        private void updateLblFontAttributes()
        {
            LabelComponent.FontAttributes = FontAttributes;
        }

        ///<summary>
        ///    Updates label font family.
        ///</summary>
        private void updateLblFontFamily()
        {
            LabelComponent.FontFamily = FontFamily;
        }

        ///<summary>
        ///    Updates label font size.
        ///</summary>
        private void updateLblFontSize()
        {
            LabelComponent.FontSize = FontSize;
        }

        ///<summary>
        ///    Updates label formatted text.
        ///</summary>
        private void updateLblFormattedText()
        {
            LabelComponent.FormattedText = FormattedText;
        }

        ///<summary>
        ///    Updates label horizontal text alignment.
        ///</summary>
        private void updateLblHorizontalTextAlignment()
        {
            LabelComponent.HorizontalTextAlignment = HorizontalTextAlignment;
        }

        ///<summary>
        ///    Updates label line break mode.
        ///</summary>
        private void updateLblLineBreakMode()
        {
            LabelComponent.LineBreakMode = LineBreakMode;
        }

        ///<summary>
        ///    Updates label text.
        ///</summary>
        private void updateLblText()
        {
            LabelComponent.Text = Text;
        }

        ///<summary>
        ///    Updates label text color.
        ///</summary>
        private void updateLblTextColor()
        {
            LabelComponent.TextColor = TextColor;
        }

        ///<summary>
        ///    Updates label vertical text alignment.
        ///</summary>
        private void updateLblVerticalTextAlignment()
        {
            LabelComponent.VerticalTextAlignment = VerticalTextAlignment;
        }

        #endregion
    }
}