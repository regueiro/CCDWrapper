using System;
using System.Runtime.InteropServices;
using MultiMonitorHelper.DisplayModels.XP.Enum;
using MultiMonitorHelper.DisplayModels.XP.Struct;

namespace MultiMonitorHelper.DisplayModels.XP
{
	public class XPWrapper
	{

        [DllImport("User32.dll")]
        public static extern bool EnumDisplayDevices(string lpDevice, int iDevNum, ref DisplayDevice lpDisplayDevice, int dwFlags);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DevMode devMode);

        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern bool EnumDisplaySettingsEx(string lpszDeviceName, int iModeNum, ref DevMode lpDevMode, uint dwFlags);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		private static extern DispChange ChangeDisplaySettingsEx(string deviceName, ref DevMode lpDevMode, 
                                                                IntPtr hwnd, int dwflags, IntPtr lParam);

		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		private static extern DispChange ChangeDisplaySettingsEx(string deviceName, IntPtr devmode, 
                                                                IntPtr hwnd, int dwflags, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern int ChangeDisplaySettings(ref DevMode devMode, int flags);


		/// <summary>
		/// Reads the device information using XP native functions
		/// and fills our specific structure.
		/// </summary>
		/// <param name="deviceName">Name of the device to get screen information from.</param>
		/// <returns>Fills it with screen resolution</returns>
		public void ReadDeviceInformation(string deviceName)
		{
			var vDevMode = new DevMode();
		    int rt = 0;// EnumDisplaySettings(deviceName, -1, ref vDevMode);

			if(rt != 0)
			{
				/*
				// This is not necessiarly true
				// TODO: In future, replace that.
				// Primary is not always DISPLAY1 AFAIK
				scr.Primary = deviceName == "\\\\.\\DISPLAY1";
				scr.BitsPerPixel = 1 << vDevMode.dmBitsPerPel;
				scr.Bounds = new Rectangle(vDevMode.dmPositionX, vDevMode.dmPositionY,
											vDevMode.dmPelsWidth, vDevMode.dmPelsHeight);
				scr.WorkingArea = new Rectangle(vDevMode.dmPositionX, vDevMode.dmPositionY,
											vDevMode.dmPelsWidth, vDevMode.dmPelsHeight);
				scr.DeviceName = vDevMode.dmDeviceName;*/
			}

		}

		public void GetScreens()
		{
			/*var scrList = new List<ScreenUnsealed>();

			ScreenUnsealed primary = ReadDeviceInformation("\\\\.\\DISPLAY1");
			ScreenUnsealed secondary = ReadDeviceInformation("\\\\.\\DISPLAY2");

			if(primary != null) scrList.Add(primary);
			if(secondary != null) scrList.Add(secondary);
			*/

		}


		public bool ChangeSecondaryResolution(int width, int height)
		{
			/*
			var dm = new DevMode
			             {
			                 dmDeviceName = new String(new char[32]),
			                 dmFormName = new String(new char[32])
			             };
		    dm.dmSize = (short)Marshal.SizeOf (dm);

			if (0 != EnumDisplaySettings("\\\\.\\DISPLAY2", 1, ref dm))
			{
				dm.dmPelsWidth = width;
				dm.dmPelsHeight = height;

				return ChangeDisplaySettingsEx("\\\\.\\DISPLAY2", ref dm, IntPtr.Zero,
					(int)CdsFlags.UpdateRegistry, IntPtr.Zero) == (int)DispChange.Successful;
			}
			return false;*/

			return true;
		}

		public bool SetExtended()
		{
			/*const string szActiveDeviceName = "\\\\.\\DISPLAY1";
			const string szInactiveDeviceName = "\\\\.\\DISPLAY2";

			var dmPrimary = new DevMode();
			var dmSecondary = new DevMode();
			var dmTemp = new DevMode();

			dmPrimary.dmDeviceName = new String(new char[32]);
			dmPrimary.dmFormName = new String(new char[32]);
			dmSecondary.dmDeviceName = new String(new char[32]);
			dmSecondary.dmFormName = new String(new char[32]);
			dmTemp.dmDeviceName = new String(new char[32]);
			dmTemp.dmFormName = new String(new char[32]);

			dmPrimary.dmSize = (short)Marshal.SizeOf(dmPrimary);
			dmSecondary.dmSize = (short)Marshal.SizeOf(dmSecondary);
			dmTemp.dmSize = (short)Marshal.SizeOf(dmTemp);

			if (EnumDisplaySettings(szActiveDeviceName, -1, ref dmTemp) == 0)
				return false;

			dmPrimary.dmBitsPerPel = dmTemp.dmBitsPerPel;

			dmPrimary.dmPelsHeight = dmTemp.dmPelsHeight;
			dmPrimary.dmPelsWidth = dmTemp.dmPelsWidth;


			dmPrimary.dmDisplayFrequency = dmTemp.dmDisplayFrequency;
			dmPrimary.dmFields = (int)(DM.BitsPerPixel | DM.PelsWidth | DM.PelsHeight);

			dmPrimary.dmPositionX = 0;
			dmPrimary.dmPositionY = 0;
			dmPrimary.dmFields |= (int)DM.Position;

			if (dmPrimary.dmDisplayFrequency != 0)
				dmPrimary.dmFields |= (int)DM.DisplayFrequency;

			dmSecondary.dmBitsPerPel = dmPrimary.dmBitsPerPel;

			// TODO: Some thinking is needed.
			// Currently secondary screen gets same resolution as primary
			// but what happens if secondary does not support that resolution?
			// I hope this function fails then. However we do NEED to address this
			// possible problem in future releases.
			dmSecondary.dmPelsHeight = dmPrimary.dmPelsHeight;
			dmSecondary.dmPelsWidth = dmPrimary.dmPelsWidth;
	

			dmSecondary.dmFields = (int)(DM.BitsPerPixel | DM.PelsWidth | DM.PelsHeight);

			if (dmSecondary.dmDisplayFrequency != 0)
				dmSecondary.dmFields |= (int)DM.DisplayFrequency;

			dmSecondary.dmPositionX = dmPrimary.dmPelsWidth + 1;
			dmSecondary.dmPositionY = 0;
			dmSecondary.dmFields |= (int)DM.Position;


			if (ChangeDisplaySettingsEx(szActiveDeviceName, ref dmPrimary, IntPtr.Zero,
				(int)(CdsFlags.UpdateRegistry | CdsFlags.Noreset), IntPtr.Zero) == DispChange.Successful)
			{
				if (ChangeDisplaySettingsEx(szInactiveDeviceName, ref dmSecondary, IntPtr.Zero,
					(int)(CdsFlags.UpdateRegistry | CdsFlags.Noreset), IntPtr.Zero) == DispChange.Successful)
				{
					if (ChangeDisplaySettingsEx(null, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero) == DispChange.Successful)
					{
						return (ChangeDisplaySettingsEx(szActiveDeviceName, ref dmPrimary, IntPtr.Zero, (int)(CdsFlags.UpdateRegistry |
							CdsFlags.Reset), IntPtr.Zero) == DispChange.Successful);
						
					}
				}
			}
			return false;*/

			return true;
		}
	}
}