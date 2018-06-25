using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Offline.Vision.RNOfflineVision
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNOfflineVisionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNOfflineVisionModule"/>.
        /// </summary>
        internal RNOfflineVisionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNOfflineVision";
            }
        }
    }
}
