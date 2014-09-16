using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DisplayConfigModeInfo
    {
        [FieldOffset((0))] public DisplayConfigModeInfoType infoType;

        [FieldOffset(4)] public uint id;

        [FieldOffset(8)] public LUID adapterId;

        [FieldOffset(16)] public DisplayConfigTargetMode targetMode;

        [FieldOffset(16)] public DisplayConfigSourceMode sourceMode;
    }
}