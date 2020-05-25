#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Xamarin.Forms;

namespace DigitalPlatform.Effects.Labels
{
    public class UnderlineEffect : RoutingEffect
    {
        #region Methods

        #region Constructors

        ///<summary>
        ///    Default Constructor.
        ///</summary>
        public UnderlineEffect() : base($"{EffectsGroupName.ResolutionGroupName}.{nameof(UnderlineEffect)}")
        {
        }

        #endregion

        #endregion
    }
}
