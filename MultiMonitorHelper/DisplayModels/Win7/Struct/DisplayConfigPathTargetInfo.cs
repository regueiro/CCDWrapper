using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathTargetInfo
    {
        public LUID adapterId;
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