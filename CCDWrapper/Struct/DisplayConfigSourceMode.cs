using System.Runtime.InteropServices;
using CCDWrapper.Enum;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigSourceMode
    {
        public int width;
        public int height;
        public DisplayConfigPixelFormat pixelFormat;
        public PointL position;
    }
}