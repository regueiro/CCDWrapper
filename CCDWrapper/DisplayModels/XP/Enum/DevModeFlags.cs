using System;

namespace MultiMonitorHelper.DisplayModels.XP.Enum
{
	[Flags]
	public enum DevModeFlags
	{
        Zero = 0x0,

		Orientation = 0x1,
		PaperSize = 0x2,
		PaperLength = 0x4,
		PaperWidth = 0x8,
		Scale = 0x10,
		Position = 0x20,
		Nup = 0x40,
		DisplayOrientation = 0x80,
		Copies = 0x100,
		DefaultSource = 0x200,
		PrintQuality = 0x400,
		Color = 0x800,
		Duplex = 0x1000,
		YResolution = 0x2000,
		TtOption = 0x4000,
		Collate = 0x8000,
		FormName = 0x10000,
		LogPixels = 0x20000,
		BitsPerPixel = 0x40000,
		PelsWidth = 0x80000,
		PelsHeight = 0x100000,
		DisplayFlags = 0x200000,
		DisplayFrequency = 0x400000,
		IcmMethod = 0x800000,
		IcmIntent = 0x1000000,
		MediaType = 0x2000000,
		DitherType = 0x4000000,
		PanningWidth = 0x8000000,
		PanningHeight = 0x10000000,
		DisplayFixedOutput = 0x20000000
	}
}