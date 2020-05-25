#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalPlatform.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CenteredImageButton
    {
        #region Properties

        /// <summary>
        ///     Gets/sets is busy.
        /// </summary>
        public Boolean IsBusy
        {
            get => (Boolean)GetValue(IsBusyProperty);
            set => SetValue(IsBusyProperty, value);
        }

        /// <summary>
        ///     Gets/sets spacing.
        /// </summary>
        public double Spacing
        {
            get => (double)GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }

        /// <summary>
        ///     Gets/sets is enabled.
        /// </summary>
        public new Boolean IsEnabled
        {
            get => (Boolean)GetValue(IsEnabledProperty);
            set => SetValue(IsEnabledProperty, value);
        }


        ///<summary>
        ///    Gets/sets button border color.
        ///</summary>
        public Color BtnBorderColor
        {
            get => (Color)GetValue(BtnBorderColorProperty);
            set => SetValue(BtnBorderColorProperty, value);
        }

        ///<summary>
        ///    Gets/sets button corner radius.
        ///</summary>
        public int BtnCornerRadius
        {
            get => (int)GetValue(BtnCornerRadiusProperty);
            set => SetValue(BtnCornerRadiusProperty, value);
        }

        ///<summary>
        ///    Gets/sets button border width.
        ///</summary>
        public double BorderWidth
        {
            get => (double)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }

        ///<summary>
        ///    Gets/sets button command.
        ///</summary>
        public Command Command
        {
            get => (Command)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        ///<summary>
        ///    Gets/sets button background color.
        ///</summary>
        public new Color BackgroundColor
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        ///<summary>
        ///    Gets/sets button background color.
        ///</summary>
        public double BackgroundOpacity
        {
            get => (double)GetValue(BackgroundOpacityProperty);
            set => SetValue(BackgroundOpacityProperty, value);
        }

        ///<summary>
        ///    Gets/sets image source.
        ///</summary>
        public string Image
        {
            get => (string)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
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
        ///    Gets/sets image color.
        ///</summary>
        public Color ImageColor
        {
            get => (Color)GetValue(ImageColorProperty);
            set => SetValue(ImageColorProperty, value);
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

        /// <summary>
        ///     <see cref="Aspect" /> bindable property.
        /// </summary>
        public static readonly BindableProperty AspectProperty =
            BindableProperty.Create(nameof(Aspect), typeof(Aspect), typeof(CenteredImageButton), default(Aspect),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateImgAspect());

        /// <summary>
        ///     <see cref="Spacing" /> bindable property.
        /// </summary>
        public static readonly BindableProperty SpacingProperty =
            BindableProperty.Create(nameof(Spacing), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateSpacing());

        /// <summary>
        ///     <see cref="BackgroundColor" /> bindable property.
        /// </summary>
        public new static readonly BindableProperty BackgroundColorProperty =
            BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(CenteredImageButton), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBtnBackgroundColor());

        /// <summary>
        ///     <see cref="BackgroundOpacity" /> bindable property.
        /// </summary>
        public static readonly BindableProperty BackgroundOpacityProperty =
            BindableProperty.Create(nameof(BackgroundOpacity), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBtnBackgroundOpacity());

        /// <summary>
        ///     <see cref="BorderWidth" /> bindable property.
        /// </summary>
        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBorderWidth());

        /// <summary>
        ///     <see cref="BtnBorderColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty BtnBorderColorProperty =
            BindableProperty.Create(nameof(BtnBorderColor), typeof(Color), typeof(CenteredImageButton), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBtnBorderColor());

        /// <summary>
        ///     <see cref="BtnCornerRadius" /> bindable property.
        /// </summary>
        public static readonly BindableProperty BtnCornerRadiusProperty =
            BindableProperty.Create(nameof(BtnCornerRadius), typeof(int), typeof(CenteredImageButton), default(int),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBtnCornerRadius());

        /// <summary>
        ///     <see cref="Command" /> bindable property.
        /// </summary>
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(Command), typeof(CenteredImageButton), default(Command),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateBtnCommand());

        /// <summary>
        ///     <see cref="FontAttributes" /> bindable property.
        /// </summary>
        public static readonly BindableProperty FontAttributesProperty =
            BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(CenteredImageButton),
                default(FontAttributes),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblFontAttributes());

        /// <summary>
        ///     <see cref="FontFamily" /> bindable property.
        /// </summary>
        public static readonly BindableProperty FontFamilyProperty =
            BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(CenteredImageButton), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblFontFamily());

        /// <summary>
        ///     <see cref="FontSize" /> bindable property.
        /// </summary>
        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblFontSize());

        /// <summary>
        ///     <see cref="FormattedText" /> bindable property.
        /// </summary>
        public static readonly BindableProperty FormattedTextProperty =
            BindableProperty.Create(nameof(FormattedText), typeof(FormattedString), typeof(CenteredImageButton),
                default(FormattedString),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblFormattedText());

        /// <summary>
        ///     <see cref="HorizontalTextAlignment" /> bindable property.
        /// </summary>
        public static readonly BindableProperty HorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(HorizontalTextAlignment), typeof(TextAlignment), typeof(CenteredImageButton),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblHorizontalTextAlignment());

        /// <summary>
        ///     <see cref="ImageHeight" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create(nameof(ImageHeight), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateImgHeight());

        /// <summary>
        ///     <see cref="Image" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create(nameof(Image), typeof(string), typeof(CenteredImageButton), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateImgSource());

        /// <summary>
        ///     <see cref="ImageWidth" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create(nameof(ImageWidth), typeof(double), typeof(CenteredImageButton), default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateImgWidth());

        /// <summary>
        ///     <see cref="IsBusy" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create(nameof(IsBusy), typeof(Boolean), typeof(CenteredImageButton), default(Boolean));

        /// <summary>
        ///     <see cref="IsEnabled" /> bindable property.
        /// </summary>
        public new static readonly BindableProperty IsEnabledProperty =
            BindableProperty.Create(nameof(IsEnabled), typeof(Boolean), typeof(CenteredImageButton), true);

        /// <summary>
        ///     <see cref="LineBreakMode" /> bindable property.
        /// </summary>
        public static readonly BindableProperty LineBreakModeProperty =
            BindableProperty.Create(nameof(LineBreakMode), typeof(LineBreakMode), typeof(CenteredImageButton),
                default(LineBreakMode),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblLineBreakMode());

        /// <summary>
        ///     <see cref="TextColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(CenteredImageButton), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblTextColor());

        /// <summary>
        ///     <see cref="ImageColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ImageColorProperty =
            BindableProperty.Create(nameof(ImageColor), typeof(Color), typeof(CenteredImageButton), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateImageColor());

        /// <summary>
        ///     <see cref="Text" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(CenteredImageButton), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblText());

        /// <summary>
        ///     <see cref="VerticalTextAlignment" /> bindable property.
        /// </summary>
        public static readonly BindableProperty VerticalTextAlignmentProperty =
            BindableProperty.Create(nameof(VerticalTextAlignment), typeof(TextAlignment), typeof(CenteredImageButton),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((CenteredImageButton)bindable).updateLblVerticalTextAlignment());

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Default Constructor
        /// </summary>
        public CenteredImageButton()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        ///     Grid tap gesture recognizer method.
        /// </summary>
        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (IsBusy)
            {
                return;
            }

            IsBusy = true;

            if (IsEnabled)
            {
                Task.Run(async () =>
                {
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        await OuterContainer.FadeTo(0.5, length: 200);
                        await OuterContainer.FadeTo(1, length: 200);
                    }
                    else
                    {
                        await OuterContainer.FadeTo(0.75, length: 200);
                        await OuterContainer.FadeTo(1, length: 200);
                    }
                });

                Command?.Execute(null);
            }

            IsBusy = false;
        }

        ///<summary>
        ///    updates button border color.
        ///</summary>
        private void updateBtnBorderColor()
        {
            ButtonComponent.BorderColor = BtnBorderColor;
        }

        ///<summary>
        ///    updates button corner radius.
        ///</summary>
        private void updateBtnCornerRadius()
        {
            ButtonComponent.CornerRadius = BtnCornerRadius;
        }

        ///<summary>
        ///    Updates button border width.
        ///</summary>
        private void updateBorderWidth()
        {
            ButtonComponent.BorderWidth = BorderWidth;
        }

        ///<summary>
        ///    Updates button command.
        ///</summary>
        private void updateBtnCommand()
        {
            ButtonComponent.Command = Command;
        }

        ///<summary>
        ///    Updates button background color.
        ///</summary>
        private void updateBtnBackgroundColor()
        {
            ButtonComponent.BackgroundColor = BackgroundColor;
        }

        ///<summary>
        ///    Updates button background opaciy.
        ///</summary>
        private void updateBtnBackgroundOpacity()
        {
            ButtonComponent.Opacity = BackgroundOpacity;
        }

        ///<summary>
        ///    Updates image source.
        ///</summary>
        private void updateImgSource()
        {
            ImageComponent.Source = Image;
        }

        ///<summary>
        ///    Updates image aspect.
        ///</summary>
        private void updateImgAspect()
        {
            ImageComponent.Aspect = Aspect;
        }

        ///<summary>
        ///    Updates image width.
        ///</summary>
        private void updateImgWidth()
        {
            ImageComponent.WidthRequest = ImageWidth;
        }

        ///<summary>
        ///    Updates image height.
        ///</summary>
        private void updateImgHeight()
        {
            ImageComponent.HeightRequest = ImageHeight;
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
        ///    Updates image color.
        ///</summary>
        private void updateImageColor()
        {
            ImageComponent.TintColor = ImageColor;
        }

        ///<summary>
        ///    Updates label vertical text alignment.
        ///</summary>
        private void updateLblVerticalTextAlignment()
        {
            LabelComponent.VerticalTextAlignment = VerticalTextAlignment;
        }

        ///<summary>
        ///    Updates label vertical text alignment.
        ///</summary>
        private void updateSpacing()
        {
            ButtonStackLayout.Spacing = Spacing;
        }

        #endregion
    }
}
