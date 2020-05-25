#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Xamarin.Forms;

namespace DigitalPlatform.ViewModels.Interfaces.Users
{
    ///<summary>
    ///    The start page view model interface.
    ///</summary>
    public interface IStartPageViewModel
    {
        #region Properties

        /// <summary>
        ///     Gets the navigate to login page command.
        /// </summary>
        Command NavigateToLoginPageCommand { get; }

        /// <summary>
        ///     Gets the navigate to the register page command.
        /// </summary>
        Command NavigateToRegisterPageCommand { get; }

        /// <summary>
        ///     Gets the facebook login command.
        /// </summary>
        Command FacebookLoginCommand { get; }

        /// <summary>
        ///     Gets the google login command.
        /// </summary>
        Command GoogleLoginCommand { get; }

        #endregion
    }
}
