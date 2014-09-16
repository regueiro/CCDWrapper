using System.Drawing;

namespace MultiMonitorHelper.Common.Enum
{
    public struct DisplaySettings
    {
        /// <summary>
        /// Display representation on system. Such as \\.\\DISPLAY1
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Returns the resolution of monitor. In pixels.
        /// </summary>
        public Size Resolution { get; private set; }

        /// <summary>
        /// Indicates the cordinates of origin where monitor area starts from.
        /// That is left-top cordinates.
        /// </summary>
        public Point Origin { get; private set; }

        /// <summary>
        /// Indicates degrees of rotation.
        /// </summary>
        public DisplayRotation Rotation { get; private set; }

        /// <summary>
        /// Indicates refresh rate of monitor. This is vertical refresh rate.
        /// </summary>
        public int RefreshRate { get; private set; }

        /// <summary>
        /// Indicates whenever monitor is primary, or not.
        /// </summary>
        public bool IsPrimary { get; private set; }

        /// <summary>
        /// Initialize new instance of Win7Display
        /// </summary>
        /// <param name="resolution">See Resolution property.</param>
        /// <param name="origin">See Origin property.</param>
        /// <param name="rotation">See Rotation property.</param>
        /// <param name="refreshRate">See RefreshRate property.</param>
        /// <param name="isPrimary">See IsPrimary property.</param>
        /// <param name="name">See Name property.</param>
        public DisplaySettings(Size resolution, Point origin, DisplayRotation rotation, 
            int refreshRate, bool isPrimary, string name) : this()
        {
            Resolution = resolution;
            Origin = origin;
            Rotation = rotation;
            RefreshRate = refreshRate;
            IsPrimary = isPrimary;
            Name = name;
        }
    }
}