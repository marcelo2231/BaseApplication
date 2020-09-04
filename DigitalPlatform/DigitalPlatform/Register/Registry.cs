#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism.Ioc;
using DigitalPlatform.Helpers;
using DigitalPlatform.Helpers.Interfaces;
using DigitalPlatform.Pages;
using DigitalPlatform.Validations;
using DigitalPlatform.ViewModels.Interfaces.Users;
using DigitalPlatform.ViewModels.Users;
using Xamarin.Forms;
using BusinessModels;
using BusinessControllers.Interfaces.Session;
using BusinessControllers.Session;

namespace DigitalPlatform.Register
{
    /// <summary>
    ///    The registry class.
    /// </summary>
    public static class Registry
    {
        /// <summary>
        ///    Registers everything.
        /// </summary>
        public static void Register(IContainerRegistry containerRegistry)
        {
            /// <summary>
            ///    View models.
            /// </summary>
            /************************************************************
             *                    Keep it alphabetized
             ************************************************************/
            containerRegistry.Register<ILoginPageViewModel, LoginPageViewModel>();
            containerRegistry.Register<IRegisterPageViewModel, RegisterPageViewModel>();
            containerRegistry.Register<ISessionController, SessionController>();
            containerRegistry.Register<IStartPageViewModel, StartPageViewModel>();


            /// <summary>
            ///    Navigation.
            /// </summary>
            /************************************************************
             *                    Keep it alphabetized
             ************************************************************/
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, ILoginPageViewModel>();
            containerRegistry.RegisterForNavigation<RegisterPage, IRegisterPageViewModel>();
            containerRegistry.RegisterForNavigation<StartPage, IStartPageViewModel>();


            /// <summary>
            ///    Singleton and others.
            /// </summary>
            /************************************************************
             *                    Keep it alphabetized
             ************************************************************/
            containerRegistry.RegisterInstance(new SessionContextBusinessModel());
            containerRegistry.RegisterInstance<ITypeResolver>(new TypeResolver());

        }
    }
}
