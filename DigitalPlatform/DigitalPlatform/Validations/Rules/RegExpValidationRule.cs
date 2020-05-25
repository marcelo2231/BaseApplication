#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System.Text.RegularExpressions;
using DigitalPlatform.Validations.Interfaces;

namespace DigitalPlatform.Validations.Rules
{
    /// <summary>
    ///     Regular expression validation rule
    /// </summary>
    /// <seealso cref="IRegExpValidationRule" />
    public class RegExpValidationRule : IValidationRule<string>
    {
        private readonly bool _nullOptional;

        #region Properties

        /// <summary>
        ///     Returns rule regular expression
        /// </summary>
        public string RegExp { get; }

        /// <summary>
        ///     Gets the error message.
        /// </summary>
        public string ErrorMessage { get; }

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="RegExpValidationRule" /> class.
        /// </summary>
        /// <param name="regExp">The reg exp.</param>
        /// <param name="errorDescription">The error description.</param>
        /// <param name="nullOptional"></param>
        public RegExpValidationRule(string regExp, string errorMessage, bool nullOptional = false)
        {
            _nullOptional = nullOptional;
            RegExp = regExp;
            ErrorMessage = errorMessage;
        }

        #endregion

        /// <summary>
        ///     Validates value to match regular expression rule
        /// </summary>
        public ValidationResult Validate(string valueToValidate)
        {
            if (valueToValidate == null)
            {
                return _nullOptional
                    ? new ValidationResult()
                    : new ValidationResult(ErrorMessage);
            }

            return new Regex(RegExp).IsMatch(valueToValidate)
                ? new ValidationResult()
                : new ValidationResult(ErrorMessage);
        }

        #endregion
    }
}
