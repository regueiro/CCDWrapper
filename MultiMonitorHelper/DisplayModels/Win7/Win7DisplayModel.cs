using System.Collections.Generic;
using System.Linq;
using MultiMonitorHelper.Common;
using MultiMonitorHelper.Common.Interfaces;
using MultiMonitorHelper.DisplayModels.Win7.Enum;

namespace MultiMonitorHelper.DisplayModels.Win7
{
    public partial class Win7DisplayModel : AbstractDisplayModel, IDisplayModel
    {
        #region IDisplayModel Members

        /// <summary>
        /// Call this if you want to receive list of currently active monitors.
        /// What does "active" mean in our context? It means the monitors that are "enabled"
        /// in Desktop properties screen. 
        /// </summary>
        /// <returns>list of active monitors</returns>
        public IEnumerable<IDisplay> GetActiveDisplays()
        {
            DisplayConfigTopologyId topologyId;
            var pathWraps = GetPathWrap(QueryDisplayFlags.OnlyActivePaths, out topologyId);

            // convert pathWrap elements to IDisplay elements(actually Win7Display elements)
            return pathWraps.Select(CreateDisplay);
        }

	    #endregion

    }
}