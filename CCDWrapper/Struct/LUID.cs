using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Luid
    {
        public uint LowPart;
        public uint HighPart;
    }
}