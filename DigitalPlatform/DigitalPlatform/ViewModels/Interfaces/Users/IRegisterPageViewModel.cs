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
    ///    The register page view model interface.
    ///</summary>
    public interface IRegisterPageViewModel
    {
        #region Properties

        /// <summary>
        ///     Gets/sets user information.
        /// </summary>
        UserRegisterModel UserModel { get; set; }

        /// <summary>
        ///     Gets the register command.
        /// </summary>
        Command RegisterCommand { get; }

        /// <summary>
        ///     Gets/sets accepted terms of service flag.
        /// </summary>
        bool AcceptedTerms { get; set; }

        #endregion
    }
}
