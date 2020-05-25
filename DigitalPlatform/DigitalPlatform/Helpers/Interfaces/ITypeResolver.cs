#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;

namespace DigitalPlatform.Helpers.Interfaces
{
    /// <summary>
    ///     The type resolver interface.
    /// </summary>
    public interface ITypeResolver
    {
        #region Methods

        /// <summary>
        ///     Resolves.
        /// </summary>
        T Resolve<T>();

        /// <summary>
        ///     Resolves.
        /// </summary>
        T Resolve<T>(string key);

        /// <summary>
        ///     Resolves.
        /// </summary>
        object Resolve(Type t);

        #endregion
    }
}
