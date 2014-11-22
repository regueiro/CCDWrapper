using System.Runtime.InteropServices;
using CCDWrapper.Enum;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathSourceInfo
    {
        public Luid adapterId;
        public uint id;
        public uint modeInfoIdx;

        public DisplayConfigSourceStatus statusFlags;
    }
}