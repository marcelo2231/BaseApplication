#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System.Threading.Tasks;

namespace BusinessControllers.Interfaces.Firebase
{
    public interface IFirebaseAuthenticator
    {
        bool IsSignIn();
        bool SignOut();
        Task<string> LoginWithEmailPassword(string email, string password);
        Task<string> LoginWithGoogleAccount();
    }
}
