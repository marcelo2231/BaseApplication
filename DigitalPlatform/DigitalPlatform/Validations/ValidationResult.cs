#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

namespace DigitalPlatform.Validations
{
    /// <summary>
    ///     The Validation result.
    /// </summary>
    public class ValidationResult
    {
        #region Properties

        /// <summary>
        ///     The is valid flag.
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        ///     The error message.
        /// </summary>
        public string ErrorMessage { get; }

        #endregion

        #region Methods

        #region Constructor

        /// <summary>
        ///     The Constructor.
        /// </summary>
        public ValidationResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
            IsValid = false;
        }

        /// <summary>
        ///     The Default Constructor.
        /// </summary>
        public ValidationResult()
        {
            IsValid = true;
        }

        #endregion

        #endregion
    }
}
