using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
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