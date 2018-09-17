using System;
using System.Linq;

namespace AreaCount
{
    public class PersonReportInfo
    {
        private string personNo;
        private string carNo;
        private string personName;
        private string groupName;
        private string cardType;
        private string inTime;
        private string outTime;
        private string phoneNo1;
        private string phoneNo2;

        public string PersonNo { get => personNo; set => personNo = value; }
        public string CarNo { get => carNo; set => carNo = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string CardType { get => cardType; set => cardType = value; }
        public string InTime { get => inTime; set => inTime = value; }
        public string OutTime { get => outTime; set => outTime = value; }
        public string PhoneNo1 { get => phoneNo1; set => phoneNo1 = value; }
        public string PhoneNo2 { get => phoneNo2; set => phoneNo2 = value; }
    }
}
