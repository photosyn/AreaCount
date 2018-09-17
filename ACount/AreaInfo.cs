using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCount
{
    public class AreaInfo
    {
        private string areaId;
        private string title;
        private string areaName;
        private string areaDevs;
        private int used;

        public string AreaId { get => areaId; set => areaId = value; }
        public string Title { get => title; set => title = value; }
        public string AreaName { get => areaName; set => areaName = value; }
        public string AreaDevs { get => areaDevs; set => areaDevs = value; }
        public int Used { get => used; set => used = value; }
    }
}
