using System;

namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    [Flags]
    public enum DisplayConfigSourceStatus
    {
        Zero = 0x0,
        InUse = 0x00000001
    }
}