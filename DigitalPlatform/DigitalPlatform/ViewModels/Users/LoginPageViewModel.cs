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

        #endregion

        #region Properties

        /// <summary>
        ///     Gets the navigate to forgot password page command.
        /// </summary>
        public Command NavigateToForgotPasswordPageCommand => new Command(navigateToForgotPasswordPage);

        /// <summary>
        ///     Gets the login command.
        /// </summary>
        public Command LoginCommand => new Command(login);

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
        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Resources.ResourceManager.GetString("LoginPageTitle");
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
        private void login()
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

            }

            IsBusy = false;
        }

        #endregion
    }
}
