#region Copyright

// ==================================================================================================
//   This file is part of the DigitalPlatform application.
//   Copyright ©2019 DigitalPlatform. All rights reserved.
// ==================================================================================================

#endregion

using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalPlatform.Helpers
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        #region Fields

        const string ResourceId = "DigitalPlatform.Properties.Resources";

        static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(() =>
            new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        #endregion

        #region Properties

        public string Text { get; set; }

        #endregion

        #region Methods

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            var ci = CultureInfo.CurrentCulture;

            var translation = resmgr.Value.GetString(Text, ci);

            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException(
                    String.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", Text, ResourceId,
                        ci.Name),
                    "Text");
#else
                translation = Text; // returns the key, which GETS DISPLAYED TO THE USER
#endif
            }

            return translation;
        }

        #endregion
    }
}
