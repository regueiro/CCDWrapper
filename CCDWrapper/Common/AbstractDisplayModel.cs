using System.Drawing;

namespace MultiMonitorHelper.Common
{
    /// <summary>
    /// DisplayModels inherit from here, to use "common" functionality.
    /// </summary>
    public abstract class AbstractDisplayModel
    {
        /// <summary>
        /// Indicates whenever display is primary or not.
        /// The logic is simple, according to MSDN:
        /// For display devices only, a POINTL structure that indicates the positional coordinates of
        /// the display device in reference to the desktop area. The primary display device is always located 
        /// at coordinates (0,0). 
        /// </summary>
        /// <param name="displayStart"></param>
        /// <returns></returns>
        public bool IsPrimaryDisplay(Point displayStart)
        {
            return displayStart.X == 0 && displayStart.Y == 0;
        }
    }
}
