#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism;
using Prism.Ioc;
using System.Threading.Tasks;
using DigitalPlatform.Pages;
using DigitalPlatform.Register;
using Xamarin.Forms;

namespace DigitalPlatform
{
    /// <summary>
    ///     The app class.
    /// </summary>
    public partial class App
    {
        #region Methods

        #region Constructors

        /// <summary>
        ///    Default Constructor.
        /// </summary>
        public App() : base(null) { }

        /// <summary>
        ///    Constructor.
        /// </summary>
        public App(IPlatformInitializer initializer) : base(initializer) { }

        /// <summary>
        ///    Constructor.
        /// </summary>
        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver) : base(initializer, setFormsDependencyResolver) { }
        
        #endregion

        /// <summary>
        ///     Overrides base <see cref="OnInitialized"/>.
        /// </summary>
        protected override async void OnInitialized()
        {
            InitializeComponent();
            await StartAsync();
        }

        /// <summary>
        ///     Starts application ascyn
        /// </summary>
        public async Task StartAsync()
        {
            //TODO: Check if user is checked in or not
            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(StartPage)}");
        }

        /// <summary>
        ///     Override base <see cref="RegisterTypes" />.
        /// </summary>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Registry.Register(containerRegistry);
        }

        #endregion
    }
}
