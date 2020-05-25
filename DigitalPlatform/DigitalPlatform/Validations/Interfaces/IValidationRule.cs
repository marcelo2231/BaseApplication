#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

namespace DigitalPlatform.Validations.Interfaces
{
    /// <summary>
    ///     The Validation rule Interface.
    /// </summary>
    public interface IValidationRule<in T>
    {
        #region Properties

        /// <summary>
        ///     The error message.
        /// </summary>
        string ErrorMessage { get; }

        #endregion

        #region Methods

        /// <summary>
        ///     The error message.
        /// </summary>
        ValidationResult Validate(T valueToValidate);

        #endregion
    }
}
