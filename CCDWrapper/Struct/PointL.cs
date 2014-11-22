using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PointL
    {
        public int x;
        public int y;
    }
}