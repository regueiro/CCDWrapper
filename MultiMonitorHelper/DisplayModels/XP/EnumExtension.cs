using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MultiMonitorHelper.Common.Enum;
using MultiMonitorHelper.DisplayModels.XP.Enum;

namespace MultiMonitorHelper.DisplayModels.XP
{
    public static class EnumExtension
    {
        /// <summary>
        /// This is enum mapper. Essentially it maps from display-model specific to
        /// interface specific enum. 
        /// </summary>
        /// <param name="destEnum"></param>
        /// <returns></returns>
        public static DisplayRotation ToScreenRotation(this Rotation destEnum)
        {
            DisplayRotation toSourceEnum = 0x0;
            if ((destEnum & Rotation.Default) == Rotation.Default)
                toSourceEnum |= DisplayRotation.Default;

            if ((destEnum & Rotation.Rotate180) == Rotation.Rotate180)
                toSourceEnum |= DisplayRotation.Rotated180;

            if ((destEnum & Rotation.Rotate270) == Rotation.Rotate270)
                toSourceEnum |= DisplayRotation.Rotated270;

            if ((destEnum & Rotation.Rotate90) == Rotation.Rotate90)
                toSourceEnum |= DisplayRotation.Rotated90;

            return toSourceEnum;
        }
    }
}
