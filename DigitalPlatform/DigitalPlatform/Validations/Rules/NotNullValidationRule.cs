#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using DigitalPlatform.Validations.Interfaces;

namespace DigitalPlatform.Validations.Rules
{
    /// <summary>
    ///     The not null validation rule.
    /// </summary>
    public class NotNullValidationRule<T> : IValidationRule<T>
    {
        #region Properties

        /// <summary>
        ///     The error message.
        /// </summary>
        public string ErrorMessage { get; }

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     Initializes a new instance of the <see cref="NotNullValidationRule" /> class.
        /// </summary>
        /// <param name="errorMessage">The error description.</param>
        public NotNullValidationRule(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        #endregion

        /// <summary>
        ///     The error message.
        /// </summary>
        public ValidationResult Validate(T valueToValidate)
        {
            if (valueToValidate == null)
            {
                return new ValidationResult(ErrorMessage);
            }

            return new ValidationResult();
        }

        #endregion
    }
}
