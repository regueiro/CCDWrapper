using MultiMonitorHelper.Common.Enum;

namespace MultiMonitorHelper.Common.Interfaces
{
    /// <summary>
    /// Each monitor is abstraced away with help of IDisplay.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        /// Holds all settings related to a display.
        /// The structure is immutable, so you can not change it directly.
        /// 
        /// You can however call interface specific methods, in order to change some values.
        /// </summary>
        DisplaySettings Settings { get; }

        /// <summary>
        /// Rotate Display.
        /// </summary>
        /// <param name="newRotation">
        /// The new rotation.
        /// </param>
        void Rotate(DisplayRotation newRotation);
    }
}