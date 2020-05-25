#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System.Collections.Generic;

namespace DigitalPlatform.Validations.Interfaces
{
    /// <summary>
    ///     Validation rules collection interface.
    /// </summary>
    public interface IValidationRulesCollection<T>
    {
        #region Methods

        /// <summary>
        ///     Gets validation rules colection.
        /// </summary>
        IEnumerable<IValidationRule<T>> ToList();

        /// <summary>
        ///     Validates that each value are valid for the rules in collection
        /// </summary>
        IEnumerable<string> Validate(IEnumerable<T> valuesToValidate);

        /// <summary>
        ///     Validates that value passes all rules
        /// </summary>
        IEnumerable<string> Validate(T valueToValidate);

        #endregion
    }
}
