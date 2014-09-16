using MultiMonitorHelper.Common.Enum;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7
{
    public static class EnumExtension
    {
        /// <summary>
        /// This is enum mapper. Essentially it maps from display-model specific to
        /// interface specific enum. 
        /// </summary>
        /// <param name="destEnum"></param>
        /// <returns></returns>
        public static DisplayRotation ToScreenRotation(this DisplayConfigRotation destEnum)
        {
            DisplayRotation toSourceEnum = 0x0;
            if ((destEnum & DisplayConfigRotation.Identity) == DisplayConfigRotation.Identity)
                toSourceEnum |= DisplayRotation.Default;

            if ((destEnum & DisplayConfigRotation.Rotate180) == DisplayConfigRotation.Rotate180)
                toSourceEnum |= DisplayRotation.Rotated180;

            if ((destEnum & DisplayConfigRotation.Rotate270) == DisplayConfigRotation.Rotate270)
                toSourceEnum |= DisplayRotation.Rotated270;

            if ((destEnum & DisplayConfigRotation.Rotate90) == DisplayConfigRotation.Rotate90)
                toSourceEnum |= DisplayRotation.Rotated90;

            return toSourceEnum;
        }
    }
}
