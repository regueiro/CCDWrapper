using System;

namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    [Flags]
    internal enum DisplayConfigRotation : uint
    {
        Zero = 0x0,

        Identity = 1,
        Rotate90 = 2,
        Rotate180 = 3,
        Rotate270 = 4,
    }
}
