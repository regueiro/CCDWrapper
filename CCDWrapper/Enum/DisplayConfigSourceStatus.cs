using System;

namespace CCDWrapper.Enum
{
    [Flags]
    public enum DisplayConfigSourceStatus
    {
        Zero = 0x0,
        InUse = 0x00000001
    }
}