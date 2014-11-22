using System;

namespace MultiMonitorHelper.DisplayModels.XP.Enum
{
	[Flags]
	public enum DisplayDeviceStateFlags
	{
		AttachedToDesktop = 0x1,
		MultiDriver = 0x2,
		PrimaryDevice = 0x4,
		MirroringDriver = 0x8,
		VgaCompatible = 0x16,
		Removable = 0x20,
		ModesPruned = 0x8000000,
		Remote = 0x4000000,
		Disconnect = 0x2000000
	}
}