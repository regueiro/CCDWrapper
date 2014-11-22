using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigTargetPreferredMode : IDisplayConfigInfo
    {
        public DisplayConfigDeviceInfoHeader header;
        public uint width;
        public uint height;
        public DisplayConfigTargetMode targetMode;
    }
}