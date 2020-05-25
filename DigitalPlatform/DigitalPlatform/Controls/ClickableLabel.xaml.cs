#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using DigitalPlatform.Effects.Labels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalPlatform.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClickableLabel : Label
    {
        #region Fields

        private UnderlineEffect _underlineEffect = new UnderlineEffect();

        #endregion

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
        ///     Gets/sets command.
        /// </summary>
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        /// <summary>
        ///     Gets/sets underline effect.
        /// </summary>
        public Boolean Underline
        {
            get => (Boolean)GetValue(UnderlineProperty);
            set => SetValue(UnderlineProperty, value);
        }

        #endregion

        #region Bindable Properties

        /// <summary>
        ///     <see cref="Command" /> bindable property.
        /// </summary>
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(ClickableLabel), default(ICommand));


        /// <summary>
        ///     <see cref="IsBusy" /> bindable property.
        /// </summary>
        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create(nameof(IsBusy), typeof(Boolean), typeof(ClickableLabel), default(Boolean));


        /// <summary>
        ///     <see cref="Underline" /> bindable property.
        /// </summary>
        public static readonly BindableProperty UnderlineProperty =
            BindableProperty.Create(nameof(Underline), typeof(Boolean), typeof(ClickableLabel), true,
                propertyChanged:
                (bindable, oldValue, newValue) =>
                    ((ClickableLabel)bindable).updateUnderline());

        #endregion

        #region Methods

        #region Constructors

        ///<summary>
        ///    Default Constructor.
        ///</summary>
        public ClickableLabel()
        {
            InitializeComponent();
            updateUnderline();
        }

        #endregion


        ///<summary>
        ///    Label tap gesture recognizer.
        ///</summary>
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
                        await this.FadeTo(0.5, length: 200);
                        await this.FadeTo(1, length: 200);
                    }
                    else
                    {
                        await this.FadeTo(0.75, length: 200);
                        await this.FadeTo(1, length: 200);
                    }
                });

                Command?.Execute(null);
            }

            IsBusy = false;
        }

        /// <summary>
        ///     Updates Underline.
        /// </summary>
        private void updateUnderline()
        {
            if (Underline)
            {
                Effects.Add(_underlineEffect);
            }
            else
            {
                Effects.Remove(_underlineEffect);
            }
        }

        #endregion
    }
}