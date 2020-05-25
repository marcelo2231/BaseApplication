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
    /// <summary>
    ///     The Special Entry control.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpecialEntry : ContentView
    {
        #region Properties

        ///<summary>
        ///    Gets/sets Title label font attributes.
        ///</summary>
        public FontAttributes TitleFontAttributes
        {
            get => (FontAttributes)GetValue(TitleFontAttributesProperty);
            set => SetValue(TitleFontAttributesProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title label font family.
        ///</summary>
        public string TitleFontFamily
        {
            get => (string)GetValue(TitleFontFamilyProperty);
            set => SetValue(TitleFontFamilyProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title label font size.
        ///</summary>
        public double TitleFontSize
        {
            get => (double)GetValue(TitleFontSizeProperty);
            set => SetValue(TitleFontSizeProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title label horizontal text alignment.
        ///</summary>
        public TextAlignment TitleHorizontalTextAlignment
        {
            get => (TextAlignment)GetValue(TitleHorizontalTextAlignmentProperty);
            set => SetValue(TitleHorizontalTextAlignmentProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title text.
        ///</summary>
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title label text color.
        ///</summary>
        public Color TitleTextColor
        {
            get => (Color)GetValue(TitleTextColorProperty);
            set => SetValue(TitleTextColorProperty, value);
        }

        ///<summary>
        ///    Gets/sets Title label vertical text alignment.
        ///</summary>
        public TextAlignment TitleVerticalTextAlignment
        {
            get => (TextAlignment)GetValue(TitleVerticalTextAlignmentProperty);
            set => SetValue(TitleVerticalTextAlignmentProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry label font attributes.
        ///</summary>
        public FontAttributes EntryFontAttributes
        {
            get => (FontAttributes)GetValue(EntryFontAttributesProperty);
            set => SetValue(EntryFontAttributesProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry label font family.
        ///</summary>
        public string EntryFontFamily
        {
            get => (string)GetValue(EntryFontFamilyProperty);
            set => SetValue(EntryFontFamilyProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry label horizontal text alignment.
        ///</summary>
        public TextAlignment EntryHorizontalTextAlignment
        {
            get => (TextAlignment)GetValue(EntryHorizontalTextAlignmentProperty);
            set => SetValue(EntryHorizontalTextAlignmentProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry label font size.
        ///</summary>
        public double EntryFontSize
        {
            get => (double)GetValue(EntryFontSizeProperty);
            set => SetValue(EntryFontSizeProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry text.
        ///</summary>
        public string Entry
        {
            get => (string)GetValue(EntryProperty);
            set => SetValue(EntryProperty, value);
        }

        ///<summary>
        ///    Gets/sets Entry label text color.
        ///</summary>
        public Color EntryTextColor
        {
            get => (Color)GetValue(EntryTextColorProperty);
            set => SetValue(EntryTextColorProperty, value);
        }

        /// <summary>
        ///     Gets/sets entry backgroundColor, Transparent does not work.
        /// </summary>
        public new Color BackgroundColor
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        /// <summary>
        ///     Gets/sets the is password.
        /// </summary>
        public Boolean IsPassword
        {
            get => (Boolean)GetValue(IsPasswordProperty);
            set => SetValue(IsPasswordProperty, value);
        }


        /// <summary>
        ///     Gets/sets hide image source.
        /// </summary>
        public string HideImageSource
        {
            get => (string)GetValue(HideImageSourceProperty);
            set => SetValue(HideImageSourceProperty, value);
        }

        /// <summary>
        ///     Gets/sets keyboard type.
        /// </summary>
        public Keyboard Keyboard
        {
            get => (Keyboard)GetValue(KeyboardProperty);
            set => SetValue(KeyboardProperty, value);
        }

        /// <summary>
        ///     Gets/sets ShowImageSource.
        /// </summary>
        public string ShowImageSource
        {
            get => (string)GetValue(ShowImageSourceProperty);
            set => SetValue(ShowImageSourceProperty, value);
        }

        /// <summary>
        ///     Gets/sets the password is hidden property.
        /// </summary>
        public Boolean IsHidden
        {
            get => (Boolean)GetValue(IsHiddenProperty);
            set => SetValue(IsHiddenProperty, value);
        }


        /// <summary>
        ///     Gets/sets image tint color.
        /// </summary>
        public Color ImageTintColor
        {
            get => (Color)GetValue(ImageTintColorProperty);
            set => SetValue(ImageTintColorProperty, value);
        }

        /// <summary>
        ///     Gets/sets the validation error text color.
        /// </summary>
        public Color ValidationErrorColor
        {
            get => (Color)GetValue(ValidationErrorColorProperty);
            set => SetValue(ValidationErrorColorProperty, value);
        }

        /// <summary>
        ///     Gets/sets the validation error text.
        /// </summary>
        public string ValidationErrorText
        {
            get => (string)GetValue(ValidationErrorTextProperty);
            set => SetValue(ValidationErrorTextProperty, value);
        }

        /// <summary>
        ///     Gets/sets the is valid.
        /// </summary>
        public bool IsValid
        {
            get => (bool)GetValue(IsValidProperty);
            set => SetValue(IsValidProperty, value);
        }

        /// <summary>
        ///     Gets/sets the validate command.
        /// </summary>
        public Command ValidateCommand
        {
            get => (Command)GetValue(ValidateCommandProperty);
            set => SetValue(ValidateCommandProperty, value);
        }

        #endregion

        #region Bindable Properties

        /// <summary>
        ///     <see cref="BackgroundColor" /> bindable property.
        /// </summary>
        public new static readonly BindableProperty BackgroundColorProperty =
            BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(SpecialEntry), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateBackgroundColor());

        /// <summary>
        ///     <see cref="EntryFontAttributes" /> bindable property.
        /// </summary>
        public static readonly BindableProperty EntryFontAttributesProperty =
            BindableProperty.Create(nameof(EntryFontAttributes), typeof(FontAttributes),
                typeof(SpecialEntry),
                default(FontAttributes),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryFontAttributes());

        /// <summary>
        ///     <see cref="EntryFontFamily" /> bindable property.
        /// </summary>
        public static readonly BindableProperty EntryFontFamilyProperty =
            BindableProperty.Create(nameof(EntryFontFamily), typeof(string), typeof(SpecialEntry),
                default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryFontFamily());

        /// <summary>
        ///     <see cref="EntryFontSize" /> bindable property.
        /// </summary>
        public static readonly BindableProperty EntryFontSizeProperty =
            BindableProperty.Create(nameof(EntryFontSize), typeof(double), typeof(SpecialEntry),
                default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryFontSize());

        /// <summary>
        ///     <see cref="EntryHorizontalTextAlignment" /> bindable property.
        /// </summary>
        public static readonly BindableProperty EntryHorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(EntryHorizontalTextAlignment), typeof(TextAlignment),
                typeof(SpecialEntry),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryHorizontalTextAlignment());

        ///<summary>
        ///    Label text bindable property.
        ///</summary>
        public static readonly BindableProperty EntryProperty =
            BindableProperty.Create(nameof(Entry), typeof(string), typeof(SpecialEntry), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryText());

        /// <summary>
        ///     <see cref="EntryTextColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty EntryTextColorProperty =
            BindableProperty.Create(nameof(EntryTextColor), typeof(Color), typeof(SpecialEntry),
                default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateEntryTextColor());

        /// <summary>
        ///     <see cref="HideImageSource" /> bindable property.
        /// </summary>
        public static readonly BindableProperty HideImageSourceProperty =
            BindableProperty.Create(nameof(HideImageSource), typeof(string), typeof(SpecialEntry), "hide.svg");

        /// <summary>
        ///     <see cref="Keyboard" /> bindable property.
        /// </summary>
        public static readonly BindableProperty KeyboardProperty =
            BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(SpecialEntry), default(Keyboard),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateKeyboard());

        /// <summary>
        ///     <see cref="ImageTintColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ImageTintColorProperty =
            BindableProperty.Create(nameof(ImageTintColor), typeof(Color), typeof(SpecialEntry), default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateImageTintColor());

        /// <summary>
        ///     <see cref="IsHidden" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsHiddenProperty =
            BindableProperty.Create(nameof(IsHidden), typeof(Boolean), typeof(SpecialEntry), default(Boolean),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateIsHidden());

        /// <summary>
        ///     <see cref="IsPassword" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsPasswordProperty =
            BindableProperty.Create(nameof(IsPassword), typeof(Boolean), typeof(SpecialEntry), default(Boolean),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateIsPassword());

        /// <summary>
        ///     <see cref="ShowImageSource" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ShowImageSourceProperty =
            BindableProperty.Create(nameof(ShowImageSource), typeof(string), typeof(SpecialEntry), "show.svg");

        /// <summary>
        ///     <see cref="TitleFontAttributes" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleFontAttributesProperty =
            BindableProperty.Create(nameof(TitleFontAttributes), typeof(FontAttributes),
                typeof(SpecialEntry), default(FontAttributes),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleFontAttributes());

        /// <summary>
        ///     <see cref="TitleFontFamily" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleFontFamilyProperty =
            BindableProperty.Create(nameof(TitleFontFamily), typeof(string), typeof(SpecialEntry),
                default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleFontFamily());

        /// <summary>
        ///     <see cref="TitleFontSize" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleFontSizeProperty =
            BindableProperty.Create(nameof(TitleFontSize), typeof(double), typeof(SpecialEntry),
                default(double),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleFontSize());

        /// <summary>
        ///     <see cref="TitleHorizontalTextAlignment" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleHorizontalTextAlignmentProperty =
            BindableProperty.Create(nameof(TitleHorizontalTextAlignment), typeof(TextAlignment),
                typeof(SpecialEntry),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleHorizontalTextAlignment());

        ///<summary>
        ///    Label text bindable property.
        ///</summary>
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(SpecialEntry), default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleText());

        /// <summary>
        ///     <see cref="TitleTextColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleTextColorProperty =
            BindableProperty.Create(nameof(TitleTextColor), typeof(Color), typeof(SpecialEntry),
                default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleTextColor());

        /// <summary>
        ///     <see cref="TitleVerticalTextAlignment" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TitleVerticalTextAlignmentProperty =
            BindableProperty.Create(nameof(TitleVerticalTextAlignment), typeof(TextAlignment),
                typeof(SpecialEntry),
                default(TextAlignment),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateTitleVerticalTextAlignment());

        /// <summary>
        ///     <see cref="ValidationErrorColor" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ValidationErrorColorProperty =
            BindableProperty.Create(nameof(ValidationErrorColor), typeof(Color),
                typeof(SpecialEntry),
                default(Color),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateValidationErrorColor());


        /// <summary>
        ///     <see cref="ValidationErrorText" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ValidationErrorTextProperty =
            BindableProperty.Create(nameof(ValidationErrorText), typeof(string),
                typeof(SpecialEntry),
                default(string),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateValidationErrorText());


        /// <summary>
        ///     <see cref="IsValid" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsValidProperty =
            BindableProperty.Create(nameof(IsValid), typeof(bool),
                typeof(SpecialEntry),
                true,
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((SpecialEntry)bindable).updateIsValid());

        /// <summary>
        ///     <see cref="ValidateCommand" /> bindable property.
        /// </summary>
        public static readonly BindableProperty ValidateCommandProperty =
            BindableProperty.Create(nameof(ValidateCommand), typeof(Command),
                typeof(SpecialEntry),
                default(Command));

        #endregion

        #region Methods

        #region Constructors

        ///<summary>
        ///    Default Constructor.
        ///</summary>
        public SpecialEntry()
        {
            InitializeComponent();
        }

        #endregion

        ///<summary>
        ///    Updates Title label font attributes.
        ///</summary>
        private void updateTitleFontAttributes()
        {
            TitleLabel.FontAttributes = TitleFontAttributes;
        }

        ///<summary>
        ///    Updates Title label font family.
        ///</summary>
        private void updateTitleFontFamily()
        {
            TitleLabel.FontFamily = TitleFontFamily;
        }

        ///<summary>
        ///    Updates Title label font size.
        ///</summary>
        private void updateTitleFontSize()
        {
            TitleLabel.FontSize = TitleFontSize;
        }

        ///<summary>
        ///    Updates Title label horizontal text alignment.
        ///</summary>
        private void updateTitleHorizontalTextAlignment()
        {
            TitleLabel.HorizontalTextAlignment = TitleHorizontalTextAlignment;
        }

        ///<summary>
        ///    Updates Title text.
        ///</summary>
        private void updateTitleText()
        {
            TitleLabel.Text = Title;
        }

        ///<summary>
        ///    Updates Title label text color.
        ///</summary>
        private void updateTitleTextColor()
        {
            TitleLabel.TextColor = TitleTextColor;
        }

        ///<summary>
        ///    Updates Title label vertical text alignment.
        ///</summary>
        private void updateTitleVerticalTextAlignment()
        {
            TitleLabel.VerticalTextAlignment = TitleVerticalTextAlignment;
        }

        ///<summary>
        ///    Updates Entry label font attributes.
        ///</summary>
        private void updateEntryFontAttributes()
        {
            TextEntry.FontAttributes = EntryFontAttributes;
        }

        ///<summary>
        ///    Updates Entry label font family.
        ///</summary>
        private void updateEntryFontFamily()
        {
            TextEntry.FontFamily = EntryFontFamily;
        }

        ///<summary>
        ///    Updates Entry label font size.
        ///</summary>
        private void updateEntryFontSize()
        {
            TextEntry.FontSize = EntryFontSize;
        }

        ///<summary>
        ///    Updates Entry label horizontal text alignment.
        ///</summary>
        private void updateEntryHorizontalTextAlignment()
        {
            TextEntry.HorizontalTextAlignment = EntryHorizontalTextAlignment;
        }

        ///<summary>
        ///    Updates Entry text.
        ///</summary>
        private void updateEntryText()
        {
            TextEntry.Text = Entry;

            if (ValidateCommand != null)
            {
                ValidateCommand.Execute(null);
            }
        }

        ///<summary>
        ///    Updates Entry label text color.
        ///</summary>
        private void updateEntryTextColor()
        {
            TextEntry.TextColor = IsValid ? EntryTextColor : ValidationErrorColor;
            Underline.BackgroundColor = IsValid ? EntryTextColor : ValidationErrorColor;
        }

        ///<summary>
        ///    Updates keyboard.
        ///</summary>
        private void updateKeyboard()
        {
            TextEntry.Keyboard = Keyboard;
        }

        /// <summary>
        ///     Updates entry backgroundColor, Transparent does not work.
        /// </summary>
        private void updateBackgroundColor()
        {
            OuterGrid.BackgroundColor = BackgroundColor;
        }

        /// <summary>
        ///     Entry on focused method.
        /// </summary>
        private void Entry_OnFocused(object sender, EventArgs e)
        {
            TitleLabel.TranslateTo(-20, -25, 250, Easing.CubicInOut);
        }

        /// <summary>
        ///     Entry on unfocused method.
        /// </summary>
        private void Entry_OnUnfocused(object sender, FocusEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextEntry.Text))
            {
                TitleLabel.TranslateTo(0, 0, 250, Easing.CubicInOut);
            }
        }

        /// <summary>
        ///     Entry on text changed method.
        /// </summary>
        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Entry = e.NewTextValue;
            TextChanged?.Invoke(sender, e);
        }

        /// <summary>
        ///     Image tap gesture recognizer method.
        /// </summary>
        private void ImageTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (IsHidden)
            {
                HideShowIcon.Source = HideImageSource;
                IsHidden = !IsHidden;
            }
            else
            {
                HideShowIcon.Source = ShowImageSource;
                IsHidden = !IsHidden;
            }
        }

        /// <summary>
        ///     Updates the password is hidden property.
        /// </summary>
        private void updateIsHidden()
        {
            TextEntry.IsPassword = IsHidden;
            if (IsHidden)
            {
                HideShowIcon.Source = HideImageSource;
            }
            else
            {
                HideShowIcon.Source = ShowImageSource;
            }
        }

        /// <summary>
        ///     Grid tap gesture recognizer method.
        /// </summary>
        private void GridTapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            TextEntry.Focus();
        }

        /// <summary>
        ///     Updates image tint color.
        /// </summary>
        private void updateImageTintColor()
        {
            HideShowIcon.TintColor = ImageTintColor;
        }

        /// <summary>
        ///     Updates password related icon
        /// </summary>
        private void updateIsPassword()
        {
            if (IsPassword)
            {
                HideShowIcon.IsVisible = true;
            }
            else
            {
                HideShowIcon.IsVisible = false;
            }
        }

        /// <summary>
        ///     Updates validation error text
        /// </summary>
        private void updateValidationErrorText()
        {
            ValidationError.Text = ValidationErrorText;
        }

        /// <summary>
        ///     Updates validation error color
        /// </summary>
        private void updateValidationErrorColor()
        {
            ValidationError.TextColor = ValidationErrorColor;
            updateEntryTextColor();
        }

        /// <summary>
        ///     Updates is valid
        /// </summary>
        private void updateIsValid()
        {
            ValidationError.IsVisible = !IsValid;
            updateEntryTextColor();
        }

        #endregion

        ///<summary>
        ///    Gets/sets text changed event.
        ///</summary>
        public event EventHandler<TextChangedEventArgs> TextChanged;
    }
}