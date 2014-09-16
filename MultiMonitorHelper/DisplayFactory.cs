using System;
using MultiMonitorHelper.Common.Interfaces;
using MultiMonitorHelper.DisplayModels.Win7;
using MultiMonitorHelper.DisplayModels.XP;

namespace MultiMonitorHelper
{
    /// <summary>
    /// Simple display factory class that will choose correct implementation,
    /// based on an operating system.
    /// </summary>
    public class DisplayFactory
    {
        private static IDisplayModel _displayModel;
        private static readonly object Lock = new object();

        /// <summary>
        /// Selects correct display model, based on Windows version.
        /// </summary>
        /// <returns></returns>
        public static IDisplayModel GetDisplayModel()
        {
            lock(Lock)
            {
                if (_displayModel != null)
                    return _displayModel;

                // TODO: This needs to be rethink through.
                // WHAT OPERATING SYSTEMS WE EXACTLY SUPPORT
                // AND DOES THE Win7DISPLAYMODEL ALSO SUPPORT WIN8?
                // OR DO WE NEED TO CREATE ANOTHER DISPLAYMODEL?!

                // ALSO, ARE WE AIMING FOR THREAD-SAFETY?!
                var osVersion = Environment.OSVersion;
                var isWin7 = (osVersion.Version.Major == 6 && osVersion.Version.Minor == 1);

                _displayModel = isWin7 ? (IDisplayModel) new Win7DisplayModel() : new XPDisplayModel();

                return _displayModel;
            }
        }
    }
}
