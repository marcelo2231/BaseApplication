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
    public partial class LoadingScreenControl
    {
        #region Properties

        /// <summary>
        ///     Gets/sets indicator is running.
        /// </summary>
        public bool IsRunning
        {
            get => (bool)GetValue(IsRunningProperty);
            set => SetValue(IsRunningProperty, value);
        }

        /// <summary>
        ///     Gets/sets text.
        /// </summary>
        public String Text
        {
            get => (String)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion

        #region Bindable Properties

        /// <summary>
        ///     <see cref="IsRunning" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsRunningProperty =
            BindableProperty.Create(nameof(IsRunning), typeof(bool), typeof(LoadingScreenControl), default(bool),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((LoadingScreenControl)bindable).updateIsRunning());

        /// <summary>
        ///     <see cref="Text" /> bindable property.
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(String), typeof(LoadingScreenControl), default(String),
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((LoadingScreenControl)bindable).updateText());

        #endregion

        #region Methods

        #region Constructors

        ///<summary>
        ///    Default constructor.
        ///</summary>
        public LoadingScreenControl()
        {
            InitializeComponent();
        }

        #endregion

        /// <summary>
        ///     Updates indicator is running.
        /// </summary>
        private void updateIsRunning()
        {
            IndicatorComponent.IsRunning = IsRunning;
        }

        /// <summary>
        ///     Updates text.
        /// </summary>
        private void updateText()
        {
            LabelComponent.Text = Text;
        }

        #endregion
    }
}