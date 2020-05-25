#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using DigitalPlatform.Helpers.Interfaces;
using Xamarin.Forms;
using Prism.DryIoc;
using Prism.Ioc;

namespace DigitalPlatform.Helpers
{
    /// <summary>
    ///     The type resolver class.
    /// </summary>
    public class TypeResolver : ITypeResolver
    {
        #region Methods

        #region Constructors

        /// <summary>
        ///     Constructor.
        /// </summary>
        public TypeResolver()
        {
        }

        #endregion

        /// <summary>
        ///     Resolves.
        /// </summary>
        public T Resolve<T>()
        {
            return ((PrismApplication)Application.Current).Container.Resolve<T>();
        }

        /// <summary>
        ///     Resolves.
        /// </summary>
        public T Resolve<T>(string key)
        {
            return ((PrismApplication)Application.Current).Container.Resolve<T>(key);
        }

        /// <summary>
        ///     Resolves.
        /// </summary>
        public object Resolve(Type t)
        {
            return ((PrismApplication)Application.Current).Container.Resolve(t);
        }

        #endregion
    }
}
