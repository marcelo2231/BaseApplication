#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using BusinessControllers.Interfaces.Session;
using BusinessModels;
using System.Threading.Tasks;

namespace BusinessControllers.Session
{
    ///<summary>
    ///    The <cref="SessionController"/> class.
    ///</summary>
    public class SessionController : ISessionController
    {
        #region Methods

        #region Constructor

        ///<summary>
        ///    The <cref="SessionController"/> constructor.
        ///</summary>
        public SessionController()
        {
        }


        #endregion

        ///<summary>
        ///    Logs in the user async.
        ///</summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public async Task<bool> LoginUserAsync(string username, string password)
        {

            return true;
        }

        ///<summary>
        ///    Logs out the user async.
        ///</summary>
        public async Task<bool> LogoutUserAsync()
        {

            return true;
        }

        ///<summary>
        ///    Gets the session async.
        ///</summary>
        public async Task<SessionContextBusinessModel> GetSessionAsync()
        {

            return new SessionContextBusinessModel();
        }

        #endregion
    }
}
