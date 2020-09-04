#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using BusinessControllers.Interfaces.Firebase;
using BusinessControllers.Interfaces.Session;
using BusinessModels;
using System;
using System.Threading.Tasks;

namespace BusinessControllers.Session
{
    ///<summary>
    ///    The <cref="SessionController"/> class.
    ///</summary>
    public class SessionController : ISessionController
    {
        #region Fields

        private readonly IFirebaseAuthenticator _firebaseAuthenticator;
        private readonly SessionContextBusinessModel _sessionContextBusinessModel;

        #endregion

        #region Methods

        #region Constructor

        ///<summary>
        ///    The <cref="SessionController"/> constructor.
        ///</summary>
        /// <param name="firebaseAuthenticator">The firebase authenticator.</param>
        public SessionController(IFirebaseAuthenticator firebaseAuthenticator,
            SessionContextBusinessModel sessionContextBusinessModel)
        {
            _firebaseAuthenticator = firebaseAuthenticator ?? throw new ArgumentNullException(nameof(firebaseAuthenticator));
            _sessionContextBusinessModel = sessionContextBusinessModel ?? throw new ArgumentNullException(nameof(sessionContextBusinessModel));
        }


        #endregion

        ///<summary>
        ///    Logs in the user async.
        ///</summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        public async Task<bool> LoginUserAsync(string username, string password)
        {
            var result = await _firebaseAuthenticator.LoginWithEmailPassword(username, password);

            if (string.IsNullOrWhiteSpace(result))
                return false;

            _sessionContextBusinessModel.Token = result;
            return true;
        }

        ///<summary>
        ///    Logs in the user with google async.
        ///</summary>
        public async Task<bool> LoginUserWithGoogleAsync()
        {
            var result = await _firebaseAuthenticator.LoginWithGoogleAccount();

            if (string.IsNullOrWhiteSpace(result))
                return false;

            _sessionContextBusinessModel.Token = result;
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
