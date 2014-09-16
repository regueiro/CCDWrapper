using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
	[StructLayout(LayoutKind.Sequential)]
	public struct DisplayConfigDeviceInfoHeader
	{
		public DisplayConfigDeviceInfoType type;
		public int size;
		public LUID adapterId;
		public uint id;
	}
}