#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Android.Gms.Auth.Api;
using Android.Gms.Auth.Api.SignIn;
using Android.Gms.Common.Apis;
using DigitalPlatform.Helpers;
using Firebase;
using Firebase.Auth;

namespace DigitalPlatform.Droid.Firebase
{
    public sealed class FirebaseService
    {

        #region Fields

        public GoogleSignInOptions gso;
        public GoogleApiClient gac;
        private static FirebaseService instance = null;

        #endregion

        #region Properties

        public static FirebaseService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new FirebaseService();
                }
                return instance;
            }
        }

        #endregion

        #region Methods

        #region Constructor

        private FirebaseService()
        {
            gso = new GoogleSignInOptions.Builder(GoogleSignInOptions.DefaultSignIn)
                    .RequestIdToken(Configurations.GoogleSignInClientID)
                    .RequestEmail()
                    .Build();
            gac = new GoogleApiClient.Builder(Android.App.Application.Context)
                .AddApi(Auth.GOOGLE_SIGN_IN_API, gso)
                .Build();
            gac.Connect();
        }

        #endregion

        public FirebaseAuth GetFirebaseAuth()
        {
            var app = FirebaseApp.InitializeApp(Android.App.Application.Context);
            FirebaseAuth mAuth;

            if (app == null)
            {
                var options = new FirebaseOptions.Builder()
                    .SetProjectId(Configurations.FirebaseProjectId)
                    .SetApplicationId(Configurations.FirebaseApplicationId)
                    .SetApiKey(Configurations.FirebaseApiKey)
                    .SetDatabaseUrl(Configurations.FirebaseUrl)
                    .SetStorageBucket(Configurations.FirebaseStorageBucket)
                    .Build();

                app = FirebaseApp.InitializeApp(Android.App.Application.Context, options);
                mAuth = FirebaseAuth.Instance;
            }
            else
            {
                mAuth = FirebaseAuth.Instance;
            }

            return mAuth;
        }

        #endregion
    }
}