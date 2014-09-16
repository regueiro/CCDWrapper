using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigRational
    {
        public uint numerator;
        public uint denominator;
    }
}