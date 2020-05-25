#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using Xamarin.Forms;

namespace DigitalPlatform.Effects.Labels
{
    public class HideUnderlineEffect : RoutingEffect
    {
        #region Methods

        #region Constructors

        ///<summary>
        ///    Default Constructor.
        ///</summary>
        public HideUnderlineEffect() : base($"{EffectsGroupName.ResolutionGroupName}.{nameof(HideUnderlineEffect)}")
        {
        }

        #endregion

        #endregion
    }
}
