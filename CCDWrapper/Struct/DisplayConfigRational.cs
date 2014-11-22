using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigRational
    {
        public uint numerator;
        public uint denominator;
    }
}