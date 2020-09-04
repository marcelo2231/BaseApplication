#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using BusinessControllers.Interfaces.Firebase;
using Firebase.Auth;
using Foundation;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace DigitalPlatform.iOS.Firebase
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        #region Fields

        //GoogleSignInOptions gso;

        #endregion

        #region Methods

        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var user = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
                return await user.User.GetIdTokenAsync();
            }
            catch (Exception e)
            {
                Log.Warning("Login Error", e.Message);
                return "";
            }
        }

        public async Task<string> LoginWithGoogleAccount()
        {
            return await LoginWithEmailPassword("", "");
        }

        public bool IsSignIn()
        {
            var user = Auth.DefaultInstance.CurrentUser;
            return user != null;
        }

        public bool SignOut()
        {
            try
            {
                _ = Auth.DefaultInstance.SignOut(out NSError error);
                return error == null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}