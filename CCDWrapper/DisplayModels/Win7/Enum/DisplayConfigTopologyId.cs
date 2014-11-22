using System;

namespace MultiMonitorHelper.DisplayModels.Win7.Enum
{
    [Flags]
    internal enum DisplayConfigTopologyId : uint
    {
        Zero = 0x0,

        Internal = 0x00000001,
        Clone = 0x00000002,
        Extend = 0x00000004,
        External = 0x00000008,
    }
}