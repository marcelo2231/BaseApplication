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
    ///    The register page view model.
    ///</summary>
    /// <seealso cref="INotifyPropertyChanged" />
    class RegisterPageViewModel : ViewModelBase, IRegisterPageViewModel
    {
        #region Fields

        private UserRegisterModel _userModel = new UserRegisterModel();
        private bool _acceptedTerms;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets/sets user information.
        /// </summary>
        public UserRegisterModel UserModel
        {
            get => _userModel;
            set => SetProperty(ref _userModel, value);
        }

        /// <summary>
        ///     Gets the register command.
        /// </summary>
        public Command RegisterCommand => new Command(register);

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

        ///<summary>
        ///    The default constructor.
        ///</summary>
        /// <param name="navigationService">The navigation service.</param>
        public RegisterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Resources.ResourceManager.GetString("RegisterPageTitle");
        }

        #endregion

        /// <summary>
        ///     Registers User.
        /// </summary>
        private void register()
        {
            IsBusy = true;

            if (!AcceptedTerms)
            {
                // TODO: Pop up message

                IsBusy = false;
                return;
            }

            if (UserModel.EmailAddress.Validate() & UserModel.PhoneNumber.Validate() &
                UserModel.FirstName.Validate() & UserModel.LastName.Validate() & UserModel.Password.Validate())
            {

            }

            IsBusy = false;
        }

        #endregion
    }
}
