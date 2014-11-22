using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using MultiMonitorHelper.Common;
using MultiMonitorHelper.Common.Enum;
using MultiMonitorHelper.Common.Interfaces;
using MultiMonitorHelper.DisplayModels.XP.Enum;
using MultiMonitorHelper.DisplayModels.XP.Struct;

namespace MultiMonitorHelper.DisplayModels.XP
{
    /// <summary>
    /// Takes care of XP specific monitor services
    /// </summary>
    public class XPDisplayModel : AbstractDisplayModel, IDisplayModel
    {
        /// <summary>
        /// Call this if you want to receive list of currently active monitors.
        /// What does "active" mean in our context? It means the monitors that are "enabled"
        /// in Desktop properties screen. 
        /// </summary>
        /// <returns>list of active monitors</returns>
        public IEnumerable<IDisplay> GetActiveDisplays()
        {
            var displayDevices = GetDisplayDevices();

            // find out resolution parameters for each display device.
            foreach(var displayDevice in displayDevices.Where(
                x => x.StateFlags.HasFlag(DisplayDeviceStateFlags.AttachedToDesktop)))
            {
                var mode = new DevMode {size = (short) Marshal.SizeOf(typeof (DevMode))};

                // -1 means current RESOLUTION for specific display.
                // you can enumerate through 0..N to find supported resolutions.
                var success = XPWrapper.EnumDisplaySettings(displayDevice.DeviceName, -1, ref mode);
                if (!success) 
                    continue;

                var origin = mode.position;
                var resolution = mode.resolution;
                var refreshRate = mode.displayFrequency;
                var rotation = mode.displayOrientation;
                var isPrimary = IsPrimaryDisplay(origin);

                if(isPrimary && !displayDevice.StateFlags.HasFlag(DisplayDeviceStateFlags.PrimaryDevice))
                    throw new Exception("SEEMS LIKE MSDN DOCUMENT LIED, IF THIS ERROR EVER HAPPENS.");
                    
                yield return new XPDisplay(new DisplaySettings(resolution, origin, 
                    rotation.ToScreenRotation(), refreshRate, isPrimary, displayDevice.DeviceName));
            }
        }

	    /// <summary>
        /// Gets all possible display devices.
        /// </summary>
        /// <returns></returns>
        private static IEnumerable<DisplayDevice> GetDisplayDevices()
        {
            var i = 0;
            var valid = true;

            while (valid)
            {
                var displayDevice = new DisplayDevice { cb = Marshal.SizeOf(typeof(DisplayDevice)) };

                valid = XPWrapper.EnumDisplayDevices(null, i, ref displayDevice, 0);
                if (valid)
                    yield return displayDevice;

                ++i;
            }
        }
    }
}