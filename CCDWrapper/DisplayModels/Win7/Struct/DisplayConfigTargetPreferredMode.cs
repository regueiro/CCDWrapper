using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct DisplayConfigTargetPreferredMode : IDisplayConfigInfo
	{
		public DisplayConfigDeviceInfoHeader header;
		public uint width;
		public uint height;
		public DisplayConfigTargetMode targetMode;
	}
}