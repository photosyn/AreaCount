using System;
using System.Linq;

namespace AreaCount
{
    public class GroupInfo
    {
        private string groupId;
        private string groupName;
        private string authId;
        private int iLevel;

        public string GroupId { get => groupId; set => groupId = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string AuthId { get => authId; set => authId = value; }
        public int ILevel { get => iLevel; set => iLevel = value; }
    }
}
