using System;

namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    [Flags]
    internal enum DisplayConfigFlags : uint
    {
        Zero = 0x0,
        PathActive = 0x00000001
    }
}