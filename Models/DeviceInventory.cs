using System.Collections.Generic;

namespace DeviceInventory
{
    public class DeviceTypeData
    {
        public DeviceTypes deviceTypes { get; set; }
        public PanelsInWorkstations panelsInWorkstations { get; set; }
    }

    public class DeviceTypes
    {
        public int totalCount { get; set; }
        public Dictionary<string, int> countByType { get; set; }
    }

    public class PanelsInWorkstations
    {
        public int totalCount { get; set; }
        public Dictionary<string, int> workStationCountByPanel { get; set; }
    }
}