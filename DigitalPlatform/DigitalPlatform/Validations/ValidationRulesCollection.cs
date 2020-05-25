#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using DigitalPlatform.Validations.Interfaces;

namespace DigitalPlatform.Validations
{
    /// <summary>
    ///     Validation rules collection.
    /// </summary>
    public class ValidationRulesCollection<T> : IValidationRulesCollection<T>
    {
        #region Fields

        private readonly IEnumerable<IValidationRule<T>> _validationRules;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        ///     Constructor.
        /// </summary>
        public ValidationRulesCollection(IEnumerable<IValidationRule<T>> validationRules)
        {
            _validationRules = validationRules ?? throw new ArgumentNullException(nameof(validationRules));
        }

        #endregion

        /// <summary>
        ///     Gets validation rules colection.
        /// </summary>
        public virtual IEnumerable<IValidationRule<T>> ToList()
        {
            return _validationRules;
        }

        /// <summary>
        ///     Validates that each value are valid for the rules in collection
        /// </summary>
        public IEnumerable<string> Validate(IEnumerable<T> valuesToValidate)
        {
            var errorsList = new List<string>();
            foreach (var valueToValidate in valuesToValidate ?? Enumerable.Empty<T>())
            {
                errorsList.AddRange(Validate(valueToValidate));
            }

            return errorsList;
        }

        /// <summary>
        ///     Validates that value passes all rules
        /// </summary>
        public virtual IEnumerable<string> Validate(T valueToValidate)
        {
            var errorsList = new List<string>();
            foreach (var validationRule in ToList())
            {
                var error = validationRule.Validate(valueToValidate);
                if (!error.IsValid)
                {
                    errorsList.Add(error.ErrorMessage);
                }
            }

            return errorsList;
        }

        #endregion
    }
}
