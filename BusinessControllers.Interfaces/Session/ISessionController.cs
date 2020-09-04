#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using BusinessModels;
using System.Threading.Tasks;

namespace BusinessControllers.Interfaces.Session
{
    ///<summary>
    ///    The <cref="ISessionController"/> interface.
    ///</summary>
    public interface ISessionController
    {
        #region Methods

        ///<summary>
        ///    Logs in the user async.
        ///</summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        Task<bool> LoginUserAsync(string username, string password);

        ///<summary>
        ///    Logs in the user with google async.
        ///</summary>
        Task<bool> LoginUserWithGoogleAsync();

        ///<summary>
        ///    Logs out the user async.
        ///</summary>
        Task<bool> LogoutUserAsync();

        ///<summary>
        ///    Gets the session async.
        ///</summary>
        Task<SessionContextBusinessModel> GetSessionAsync();

        #endregion
    }
}
