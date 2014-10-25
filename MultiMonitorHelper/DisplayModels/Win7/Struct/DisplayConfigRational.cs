using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct DisplayConfigRational
    {
        public uint numerator;
        public uint denominator;
    }
}