using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayConfigPathInfo
    {
        public DisplayConfigPathSourceInfo sourceInfo;
        public DisplayConfigPathTargetInfo targetInfo;
        public DisplayConfigFlags flags;
    }
}