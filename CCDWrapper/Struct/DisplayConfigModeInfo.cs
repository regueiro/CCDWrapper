using System.Runtime.InteropServices;
using CCDWrapper.Enum;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Explicit)]
    public struct DisplayConfigModeInfo
    {
        [FieldOffset((0))]
        public DisplayConfigModeInfoType infoType;

        [FieldOffset(4)]
        public uint id;

        [FieldOffset(8)]
        public Luid adapterId;

        [FieldOffset(16)]
        public DisplayConfigTargetMode targetMode;

        [FieldOffset(16)]
        public DisplayConfigSourceMode sourceMode;
    }
}