using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct LUID
    {
        public uint LowPart;
        public uint HighPart;
    }
}