#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;
using DigitalPlatform.Validations.Interfaces;
using Xamarin.Forms;

namespace DigitalPlatform.Validations
{
    /// <summary>
    ///     The Validatable object class.
    /// </summary>
    public class ValidatableObject<T> : BindableBase
    {
        #region Fields

        private string _errorMessageText;
        private List<string> _errors;
        private bool _isValid;
        private IValidationRulesCollection<T> _validations;
        private T _value;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the errors.
        /// </summary>
        public List<string> Errors
        {
            get => _errors;
            set => SetProperty(ref _errors, value, onChanged: () =>
            {
                if (value != null && value.Any())
                {
                    ErrorMessageText = value.FirstOrDefault();
                }
                else
                {
                    ErrorMessageText = null;
                }
            });
        }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        public T Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }

        /// <summary>
        ///     Returns true if error is valid.
        /// </summary>
        public bool IsValid
        {
            get => _isValid;
            set => SetProperty(ref _isValid, value);
        }

        /// <summary>
        ///     Gets or sets the validations.
        /// </summary>
        public IValidationRulesCollection<T> Validations
        {
            get => _validations;
            set => SetProperty(ref _validations, value);
        }

        /// <summary>
        ///     Gets/sets the error message text.
        /// </summary>
        public string ErrorMessageText
        {
            get => _errorMessageText;
            set => SetProperty(ref _errorMessageText, value);
        }

        /// <summary>
        ///     Sets the validate command.
        /// </summary>
        public Command ValidateCommand => new Command(validate);

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ValidatableObject{T}" /> class.
        /// </summary>
        public ValidatableObject()
        {
            IsValid = true;
            Errors = new List<string>();
        }

        #endregion

        private void validate()
        {
            Validate();
        }

        /// <summary>
        ///     Validates this instance.
        /// </summary>
        public bool Validate()
        {
            Errors.Clear();
            IsValid = true;

            if (hasValidators())
            {
                var errors = _validations.Validate(_value).ToList();
                if (errors.Any())
                {
                    IsValid = false;
                    Errors = errors;
                }
            }

            return IsValid;
        }

        /// <summary>
        ///     Drops all validation errors
        /// </summary>
        public void DropValidationErrors()
        {
            ErrorMessageText = string.Empty;
            Errors.Clear();
            IsValid = true;
        }

        private bool hasValidators()
        {
            return Validations != null;
        }

        #endregion
    }
}