using System.Runtime.InteropServices;
using CCDWrapper.Enum;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathTargetInfo
    {
        public Luid adapterId;
        public uint id;
        public uint modeInfoIdx;
        public DisplayConfigVideoOutputTechnology outputTechnology;
        public DisplayConfigRotation rotation;
        public DisplayConfigScaling scaling;
        public DisplayConfigRational refreshRate;
        public DisplayConfigScanLineOrdering scanLineOrdering;

        public bool targetAvailable;
        public DisplayConfigTargetStatus statusFlags;
    }
}