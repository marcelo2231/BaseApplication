#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism.Navigation;
using System.ComponentModel;
using DigitalPlatform.Pages;
using DigitalPlatform.Properties;
using DigitalPlatform.ViewModels.Interfaces.Users;
using Xamarin.Forms;
using BusinessControllers.Interfaces.Session;
using System;
using System.Threading.Tasks;

namespace DigitalPlatform.ViewModels.Users
{
    ///<summary>
    ///    The start page view model.
    ///</summary>
    /// <seealso cref="INotifyPropertyChanged" />
    public class StartPageViewModel : ViewModelBase, IStartPageViewModel
    {
        #region Fields

        private readonly ISessionController _sessionController;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the navigate to login page command.
        /// </summary>
        public Command NavigateToLoginPageCommand => new Command(navigateToLoginPage);

        /// <summary>
        ///     Gets the navigate to the register page command.
        /// </summary>
        public Command NavigateToRegisterPageCommand => new Command(navigateToRegisterPage);

        /// <summary>
        ///     Gets the facebook login command.
        /// </summary>
        public Command FacebookLoginCommand => new Command(navigateFacebookLogin);

        /// <summary>
        ///     Gets the google login command.
        /// </summary>
        public Command GoogleLoginCommand => new Command(async () => await navigateGoogleLoginAsync());

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        public StartPageViewModel(INavigationService navigationService,
            ISessionController sessionController) : base(navigationService)
        {
            Resources.ResourceManager.GetString("StartPageTitle");

            _sessionController = sessionController ?? throw new ArgumentNullException(nameof(sessionController));
        }

        #endregion

        /// <summary>
        ///     Navigates to login page.
        /// </summary>
        private async void navigateToLoginPage()
        {
            IsBusy = true;

            await NavigationService.NavigateAsync(nameof(LoginPage));

            IsBusy = false;
        }

        /// <summary>
        ///     Navigates to register page.
        /// </summary>
        private async void navigateToRegisterPage()
        {
            IsBusy = true;

            await NavigationService.NavigateAsync(nameof(RegisterPage));

            IsBusy = false;
        }

        /// <summary>
        ///     Navigates to facebook login.
        /// </summary>
        private void navigateFacebookLogin()
        {
            IsBusy = true;



            IsBusy = false;
        }

        /// <summary>
        ///     Navigates to google login.
        /// </summary>
        private async Task navigateGoogleLoginAsync()
        {
            IsBusy = true;

            var result = await _sessionController.LoginUserWithGoogleAsync();

            IsBusy = false;
        }

        #endregion
    }
}