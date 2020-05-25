#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using DigitalPlatform.Properties;
using DigitalPlatform.Validations;
using DigitalPlatform.Validations.Rules;

namespace DigitalPlatform.ViewModels.Users
{
    public class UserRegisterModel
    {
        #region Properties

        /// <summary>
        ///     Gets/sets the user Email Address.
        /// </summary>
        public ValidatableObject<string> EmailAddress { get; set; }

        /// <summary>
        ///     Gets/sets the user first name.
        /// </summary>
        public ValidatableObject<string> FirstName { get; set; }

        /// <summary>
        ///     Gets/sets the user last name.
        /// </summary>
        public ValidatableObject<string> LastName { get; set; }

        /// <summary>
        ///     Gets/sets the user phone number.
        /// </summary>
        public ValidatableObject<string> PhoneNumber { get; set; }

        /// <summary>
        ///     Gets/sets the user password.
        /// </summary>
        public ValidatableObject<string> Password { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Default constructor
        /// </summary>
        public UserRegisterModel()
        {
            FirstName = new ValidatableObject<string>();
            FirstName.Validations = new ValidationRulesCollection<string>(new[]{
                new NotNullNorWhiteSpace(Resources.ResourceManager.GetString("NullOrWhiteSpaceValidationErrorMessage"))
            });
            LastName = new ValidatableObject<string>();
            LastName.Validations = new ValidationRulesCollection<string>(new[]{
                new NotNullNorWhiteSpace(Resources.ResourceManager.GetString("NullOrWhiteSpaceValidationErrorMessage"))
            });
            EmailAddress = new ValidatableObject<string>();
            EmailAddress.Validations = new ValidationRulesCollection<string>(new[]{
                new RegExpValidationRule(Resources.ResourceManager.GetString("EmailAddressPolicy"),
                Resources.ResourceManager.GetString("InvalidInputErrorMessage"))
            });
            PhoneNumber = new ValidatableObject<string>();
            PhoneNumber.Validations = new ValidationRulesCollection<string>(new[]{
                new RegExpValidationRule(Resources.ResourceManager.GetString("PhoneNumberPolicy"),
                Resources.ResourceManager.GetString("InvalidInputErrorMessage"))
            });
            Password = new ValidatableObject<string>();
            Password.Validations = new ValidationRulesCollection<string>(new[]{
                new RegExpValidationRule(Resources.ResourceManager.GetString("PasswordPolicy"),
                Resources.ResourceManager.GetString("InvalidInputErrorMessage"))
            });
        }

        #endregion
    }
}
