using System;

namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    [Flags]
    internal enum DisplayConfigModeInfoType : uint
    {
        Zero = 0,

        Source = 1,
        Target = 2,
    }
}