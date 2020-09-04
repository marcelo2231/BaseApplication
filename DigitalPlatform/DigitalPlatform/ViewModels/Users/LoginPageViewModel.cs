#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism.Navigation;
using System.ComponentModel;
using DigitalPlatform.Properties;
using DigitalPlatform.ViewModels.Interfaces.Users;
using Xamarin.Forms;
using System;
using BusinessControllers.Interfaces.Session;
using System.Threading.Tasks;

namespace DigitalPlatform.ViewModels.Users
{
    ///<summary>
    ///    The login page view model.
    ///</summary>
    /// <seealso cref="INotifyPropertyChanged" />
    public class LoginPageViewModel : ViewModelBase, ILoginPageViewModel
    {
        #region Fields
        
        private UserLoginModel _userModel = new UserLoginModel();
        private bool _acceptedTerms;
        private readonly ISessionController _sessionController;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the navigate to forgot password page command.
        /// </summary>
        public Command NavigateToForgotPasswordPageCommand => new Command(navigateToForgotPasswordPage);

        /// <summary>
        ///     Gets the login command.
        /// </summary>
        public Command LoginCommand => new Command(async () => await login());

        /// <summary>
        ///     Gets/sets user information.
        /// </summary>
        public UserLoginModel UserModel
        {
            get => _userModel;
            set => SetProperty(ref _userModel, value);
        }

        /// <summary>
        ///     Gets/sets accepted terms of service flag.
        /// </summary>
        public bool AcceptedTerms
        {
            get => _acceptedTerms;
            set => SetProperty(ref _acceptedTerms, value);
        }

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Default Constructor.
        /// </summary>
        /// <param name="navigationService">The navigation service.</param>
        public LoginPageViewModel(INavigationService navigationService,
            ISessionController sessionController) : base(navigationService)
        {
            Resources.ResourceManager.GetString("LoginPageTitle");

            _sessionController = sessionController ?? throw new ArgumentNullException(nameof(sessionController));
        }

        #endregion

        /// <summary>
        ///     Navigates to forgot password page.
        /// </summary>
        private async void navigateToForgotPasswordPage()
        {
            IsBusy = true;



            IsBusy = false;
        }

        /// <summary>
        ///     Login User.
        /// </summary>
        private async Task login()
        {
            IsBusy = true;

            if (!AcceptedTerms)
            {
                // TODO: Pop up message

                IsBusy = false;
                return;
            }

            if (UserModel.EmailAddress.Validate() & UserModel.Password.Validate())
            {
                var result = await _sessionController.LoginUserAsync(UserModel.EmailAddress.Value, UserModel.Password.Value);
            }

            IsBusy = false;
        }

        #endregion
    }
}
