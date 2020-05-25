#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.ComponentModel;

namespace DigitalPlatform.ViewModels
{
    ///<summary>
    ///    The register page view model.
    ///</summary>
    /// <seealso cref="INotifyPropertyChanged" />
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        #region Fields

        private bool _isBusy;
        private string _title;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets/sets page is busy.
        /// </summary>
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        /// <summary>
        ///     Gets/sets the page title.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        /// <summary>
        ///     Gets the navigation service.
        /// </summary>
        protected INavigationService NavigationService { get; private set; }

        #endregion

        #region Methods

        #region Constructors

        ///<summary>
        ///    The default constructor.
        ///</summary>
        /// <param name="navigationService">The navigation service.</param>
        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        }

        ///<summary>
        ///    Implements Initialize.
        ///</summary>
        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        ///<summary>
        ///    Implements OnNavigatedFrom.
        ///</summary>
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        ///<summary>
        ///    Implements OnNavigatedTo.
        ///</summary>
        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        ///<summary>
        ///    Implements Destroy.
        ///</summary>
        public void Destroy()
        {
        }

        #endregion

        #endregion
    }
}
