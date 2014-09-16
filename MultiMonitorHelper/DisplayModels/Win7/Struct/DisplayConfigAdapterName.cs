using System.Runtime.InteropServices;

namespace MultiMonitorHelper.DisplayModels.Win7.Struct
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DisplayConfigAdapterName : IDisplayConfigInfo
	{
		public DisplayConfigDeviceInfoHeader header;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]public string adapterDevicePath;
	}
}