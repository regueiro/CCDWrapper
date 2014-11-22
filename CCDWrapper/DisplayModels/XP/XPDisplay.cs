using MultiMonitorHelper.Common;
using MultiMonitorHelper.Common.Interfaces;

namespace MultiMonitorHelper.DisplayModels.XP
{
    using MultiMonitorHelper.Common.Enum;

    /// <summary>
    /// Handles XP specific logic for monitor.
    /// </summary>
    public class XPDisplay : IDisplay
    {
        /// <summary>
        /// Initialize new instance of XPDisplay
        /// </summary>
        public XPDisplay(DisplaySettings settings)
        {
            Settings = settings;
        }

        /// <summary>
        /// Holds all settings related to a display.
        /// The structure is immutable, so you can not change it directly.
        /// 
        /// You can however call interface specific methods, in order to change some values.
        /// </summary>
        public DisplaySettings Settings { get; private set; }

        public void Rotate(DisplayRotation newRotation)
        {
            throw new System.NotImplementedException();
        }
    }
}