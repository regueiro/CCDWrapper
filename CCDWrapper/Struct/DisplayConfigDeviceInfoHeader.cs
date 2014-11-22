using System.Runtime.InteropServices;
using CCDWrapper.Enum;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigDeviceInfoHeader
    {
        public DisplayConfigDeviceInfoType type;
        public int size;
        public Luid adapterId;
        public uint id;
    }
}