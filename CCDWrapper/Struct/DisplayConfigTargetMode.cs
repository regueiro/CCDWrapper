using System.Runtime.InteropServices;

namespace CCDWrapper.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigTargetMode
    {
        public DisplayConfigVideoSignalInfo targetVideoSignalInfo;
    }
}