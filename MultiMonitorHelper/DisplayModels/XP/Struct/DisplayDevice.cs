using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.XP.Enum;

namespace MultiMonitorHelper.DisplayModels.XP.Struct
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct DisplayDevice
	{
		[MarshalAs(UnmanagedType.U4)] public int cb;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string DeviceName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string DeviceString;
		[MarshalAs(UnmanagedType.U4)] public DisplayDeviceStateFlags StateFlags;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string DeviceID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] public string DeviceKey;
	}
}