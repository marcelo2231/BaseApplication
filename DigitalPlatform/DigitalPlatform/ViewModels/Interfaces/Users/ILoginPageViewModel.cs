#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using DigitalPlatform.ViewModels.Users;
using Xamarin.Forms;

namespace DigitalPlatform.ViewModels.Interfaces.Users
{
    ///<summary>
    ///    The login page view model interface.
    ///</summary>
    public interface ILoginPageViewModel
    {
        #region Properties

        /// <summary>
        ///     Gets the navigate to forgot password page command.
        /// </summary>
        Command NavigateToForgotPasswordPageCommand { get; }

        /// <summary>
        ///     Gets the login command.
        /// </summary>
        Command LoginCommand { get; }

        /// <summary>
        ///     Gets/sets user information.
        /// </summary>
        UserLoginModel UserModel { get; set; }

        /// <summary>
        ///     Gets/sets accepted terms of service flag.
        /// </summary>
        bool AcceptedTerms { get; set; }

        #endregion
    }
}
