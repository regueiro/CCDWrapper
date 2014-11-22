using System.Drawing;
using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.XP.Enum;

namespace MultiMonitorHelper.DisplayModels.XP.Struct
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
	public struct DevMode
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string deviceName;

		public short specVersion;
		public short driverVersion;
		public short size;
		public short driverExtra;
		public DevModeFlags fields;
		public Point position;
		public Rotation displayOrientation;
		public int displayFixedOutput;
		public short color;
		public short duplex;
		public short yResolution;
		public short TTOption;
		public short collate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] public string formName;

		public short logPixels;
		public short bitsPerPel;
	    public Size resolution;
		public int displayFlags;
		public int displayFrequency;
		public int iCMMethod;
		public int iCMIntent;
		public int mediaType;
		public int ditherType;
		public int reserved1;
		public int reserved2;
		public int panningWidth;
		public int panningHeight;

	};
}