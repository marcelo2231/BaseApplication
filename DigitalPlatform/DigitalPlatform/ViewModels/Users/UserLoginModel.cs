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
    public class UserLoginModel
    {
        #region Properties

        /// <summary>
        ///     Gets/sets the user Email Address.
        /// </summary>
        public ValidatableObject<string> EmailAddress { get; set; }

        /// <summary>
        ///     Gets/sets the user password.
        /// </summary>
        public ValidatableObject<string> Password { get; set; }

        #endregion

        #region Methods

        /// <summary>
        ///     Default constructor
        /// </summary>
        public UserLoginModel()
        {
            EmailAddress = new ValidatableObject<string>();
            EmailAddress.Validations = new ValidationRulesCollection<string>(new[]{
                new RegExpValidationRule(Resources.ResourceManager.GetString("EmailAddressPolicy"),
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
