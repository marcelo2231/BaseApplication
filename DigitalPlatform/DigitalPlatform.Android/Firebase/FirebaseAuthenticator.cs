#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Android.Content.Res;
using Android.Gms.Auth.Api;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Common.Apis;
using Android.Util;
using BusinessControllers.Interfaces.Firebase;
using DigitalPlatform.Helpers;
using Firebase;
using Firebase.Auth;
using System;
using System.Threading.Tasks;

namespace DigitalPlatform.Droid.Firebase
{
    public class FirebaseAuthenticator : IFirebaseAuthenticator
    {
        #region Methods

        public async Task<string> LoginWithEmailPassword(string email, string password)
        {
            try
            {
                var firebase = FirebaseService.Instance.GetFirebaseAuth();
                var user = await firebase.
                                SignInWithEmailAndPasswordAsync(email, password);
                var token = await user.User.GetIdTokenAsync(false);
                return token.Token;
            }
            catch (Exception e)
            {
                Log.Debug("Login Error", e.Message);
                return "";
            }
        }
        public async Task<string> LoginWithGoogleAccount()
        {
            try
            {
                var firebase = FirebaseService.Instance.GetFirebaseAuth();
                var intent = Auth.GoogleSignInApi.GetSignInIntent(FirebaseService.Instance.gac);
                Android.App.Application.Context.StartActivity(intent);

                return "";
            }
            catch (Exception e)
            {
                Log.Debug("Login Error", e.Message);
                return "";
            }
        }

        public bool IsSignIn()
        {
            var firebase = FirebaseService.Instance.GetFirebaseAuth();
            return firebase.CurrentUser != null;
        }

        public bool SignOut()
        {
            try
            {
                var firebase = FirebaseService.Instance.GetFirebaseAuth();
                firebase.SignOut();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}