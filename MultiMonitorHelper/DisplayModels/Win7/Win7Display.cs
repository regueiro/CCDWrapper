using System;
using MultiMonitorHelper.Common;
using MultiMonitorHelper.Common.Enum;
using MultiMonitorHelper.Common.Interfaces;

namespace MultiMonitorHelper.DisplayModels.Win7
{
    public class Win7Display : IDisplay
    {
        /// <summary>
        /// Initialize new instance of Win7Display
        /// </summary>
        public Win7Display(DisplaySettings settings)
        {
            Settings = settings;
        }

        #region IDisplay Members

        /// <summary>
        /// Holds all settings related to a display.
        /// The structure is immutable, so you can not change it directly.
        /// 
        /// You can however call interface specific methods, in order to change some values.
        /// </summary>
        public DisplaySettings Settings { get; private set; }

        /// <summary>
        /// The rotate.
        /// </summary>
        /// <param name="newRotation">
        /// The new rotation.
        /// </param>
        public void Rotate(DisplayRotation newRotation)
        {
           throw new Exception("Rotate not possible.");
        }

        #endregion
    }
}