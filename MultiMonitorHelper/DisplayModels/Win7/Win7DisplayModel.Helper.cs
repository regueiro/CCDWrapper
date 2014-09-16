using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using MultiMonitorHelper.Common.Enum;
using MultiMonitorHelper.Common.Interfaces;
using MultiMonitorHelper.DisplayModels.Win7.Enum;
using MultiMonitorHelper.DisplayModels.Win7.Struct;

namespace MultiMonitorHelper.DisplayModels.Win7
{
    public partial class Win7DisplayModel
    {
        /// <summary>
        /// Creates new instance of Win7Display
        /// </summary>
        /// <returns></returns>
        private IDisplay CreateDisplay(DisplayConfigPathWrap pathWrap)
        {
            var path = pathWrap.Path;
            var sourceModeInfo = pathWrap.Modes.First(x => x.infoType == DisplayConfigModeInfoType.Source);
            var origin = new Point
            {
                X = sourceModeInfo.sourceMode.position.x,
                Y = sourceModeInfo.sourceMode.position.y
            };

            var resolution = new Size
            {
                Width = sourceModeInfo.sourceMode.width,
                Height = sourceModeInfo.sourceMode.height
            };

            // TODO; MAKE SURE THAT IT IS POSSIBLE TO DIVIDE THIS
            // WHAT IF DENOMINATOR IS ZERO?!
            var refreshRate =
                (int)Math.Round((double)path.targetInfo.refreshRate.numerator / path.targetInfo.refreshRate.denominator);
            var rotationOriginal = path.targetInfo.rotation;
            var isPrimary = IsPrimaryDisplay(origin);


            // query for display name.
            DisplayConfigSourceDeviceName displayConfigSourceDeviceName;

            var displayName = "<unidentified>"; // TODO refactor it out
            var nameStatus = GetDisplayConfigSourceDeviceName(sourceModeInfo, out displayConfigSourceDeviceName);
            if (nameStatus == StatusCode.Success)
                displayName = displayConfigSourceDeviceName.viewGdiDeviceName;

            return new Win7Display(new DisplaySettings(resolution, origin,
                                                       rotationOriginal.ToScreenRotation(), refreshRate, isPrimary,
                                                       displayName));
        }

        /// <summary>
        /// This method can be used in order to filter out specific paths that we are interested,
        /// a long with their corresponding paths. 
        /// </summary>
        /// <param name="pathType"></param>
        /// <param name="topologyId"></param>
        /// <returns></returns>
        private static IEnumerable<DisplayConfigPathWrap> GetPathWrap(QueryDisplayFlags pathType,
            out DisplayConfigTopologyId topologyId)
        {
            topologyId = DisplayConfigTopologyId.Zero;

            int numPathArrayElements;
            int numModeInfoArrayElements;

            var status = CCDWrapper.GetDisplayConfigBufferSizes(
                pathType,
                out numPathArrayElements,
                out numModeInfoArrayElements);

            if (status != StatusCode.Success)
            {
                // TODO; POSSIBLY HANDLE SOME OF THE CASES.
                var reason = string.Format("GetDisplayConfigBufferSizesFailed() failed. Status: {0}", status);
                throw new Exception(reason);
            }

            var pathInfoArray = new DisplayConfigPathInfo[numPathArrayElements];
            var modeInfoArray = new DisplayConfigModeInfo[numModeInfoArrayElements];

            // topology ID only valid with QDC_DATABASE_CURRENT
            var queryDisplayStatus = pathType == QueryDisplayFlags.DatabaseCurrent ?
                CCDWrapper.QueryDisplayConfig(
                pathType,
                ref numPathArrayElements, pathInfoArray,
                ref numModeInfoArrayElements, modeInfoArray, out topologyId) :

                CCDWrapper.QueryDisplayConfig(
                pathType,
                ref numPathArrayElements, pathInfoArray,
                ref numModeInfoArrayElements, modeInfoArray);
            //////////////////////

            if (queryDisplayStatus != StatusCode.Success)
            {
                // TODO; POSSIBLY HANDLE SOME OF THE CASES.
                var reason = string.Format("QueryDisplayConfig() failed. Status: {0}", queryDisplayStatus);
                throw new Exception(reason);
            }

            var list = new List<DisplayConfigPathWrap>();
            foreach (var path in pathInfoArray)
            {
                var outputModes = new List<DisplayConfigModeInfo>();
                foreach (var modeIndex in new[]
                                          {
                                              path.sourceInfo.modeInfoIdx,
                                              path.targetInfo.modeInfoIdx
                                          })
                {
                    if (modeIndex >= 0 && modeIndex < modeInfoArray.Length)
                        outputModes.Add(modeInfoArray[modeIndex]);
                }

                list.Add(new DisplayConfigPathWrap(path, outputModes));
            }
            return list;
        }

        /// <summary>
        /// This method give you access to monitor device name.
        /// Such as "\\DISPLAY1"
        /// </summary>
        /// <param name="sourceModeInfo"></param>
        /// <param name="displayConfigSourceDeviceName"></param>
        /// <returns></returns>
        private static StatusCode GetDisplayConfigSourceDeviceName(
            DisplayConfigModeInfo sourceModeInfo,
            out DisplayConfigSourceDeviceName displayConfigSourceDeviceName)
        {
            displayConfigSourceDeviceName = new DisplayConfigSourceDeviceName
            {
                header = new DisplayConfigDeviceInfoHeader
                {
                    adapterId = sourceModeInfo.adapterId,
                    id = sourceModeInfo.id,
                    size =
                        Marshal.SizeOf(
                            typeof(DisplayConfigSourceDeviceName)),
                    type = DisplayConfigDeviceInfoType.GetSourceName,
                }
            };

            return CCDWrapper.DisplayConfigGetDeviceInfo(ref displayConfigSourceDeviceName);
        }

        private static StatusCode GetDisplayConfigTargetDeviceName(
            DisplayConfigModeInfo targetModeInfo,
            out DisplayConfigTargetDeviceName displayConfigTargetDeviceName)
        {
            displayConfigTargetDeviceName = new DisplayConfigTargetDeviceName
            {
                header = new DisplayConfigDeviceInfoHeader
                {
                    adapterId = targetModeInfo.adapterId,
                    id = targetModeInfo.id,
                    size =
                        Marshal.SizeOf(
                            typeof(DisplayConfigTargetDeviceName)),
                    type = DisplayConfigDeviceInfoType.GetTargetName,
                }
            };


            return CCDWrapper.DisplayConfigGetDeviceInfo(ref displayConfigTargetDeviceName);
        }
    }
}
