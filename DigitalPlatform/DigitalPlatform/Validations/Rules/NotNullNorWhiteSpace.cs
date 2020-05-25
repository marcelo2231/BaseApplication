#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using DigitalPlatform.Validations.Interfaces;

namespace DigitalPlatform.Validations.Rules
{
    public class NotNullNorWhiteSpace : IValidationRule<string>
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
        ///     Initializes a new instance of the <see cref="NotNullNorWhiteSpace" /> class.
        /// </summary>
        /// <param name="errorMessage">The error description.</param>
        public NotNullNorWhiteSpace(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        #endregion

        /// <summary>
        ///     The error message.
        /// </summary>
        public ValidationResult Validate(string valueToValidate)
        {
            if (string.IsNullOrWhiteSpace(valueToValidate))
            {
                return new ValidationResult(ErrorMessage);
            }

            return new ValidationResult();
        }

        #endregion
    }
}
