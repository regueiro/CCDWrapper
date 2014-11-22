using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfig2DRegion
    {
        public uint cx;
        public uint cy;
    }
}