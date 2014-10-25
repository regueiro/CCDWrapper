using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct DisplayConfig2DRegion
    {
        public uint cx;
        public uint cy;
    }
}