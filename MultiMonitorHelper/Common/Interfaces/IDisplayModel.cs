using System.Collections.Generic;

namespace MultiMonitorHelper.Common.Interfaces
{
    /// <summary>
    /// Each display model implementation is abstraced away with help of IDisplayModel.
    /// </summary>
    public interface IDisplayModel
    {
        /// <summary>
        /// Call this if you want to receive list of currently active monitors.
        /// What does "active" mean in our context? It means the monitors that are "enabled"
        /// in Desktop properties screen. 
        /// </summary>
        /// <returns>list of active monitors</returns>
        IEnumerable<IDisplay> GetActiveDisplays();
    }
}