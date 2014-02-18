using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract.Entity
{
    public class InformationAssistant
    {
        public int InformationAssistantId { set; get; }
        public string InformationAssistantName { set; get; }
        public string PhoneNumber { set; get; }
        public string Type { set; get; }
        public string Company { set; get; }
        public string City { set; get; }
        public string InformationLevel { set; get; }
        public string ReVisitTime { set; get; }
        public Nullable<int> OrderId { set; get; }
        public string Address { set; get; }
        public string ReVisistPeriod { set; get; }
        public bool IsVisit { set; get; }
        public string HandSet { set; get; }
        public Employee Employees { get; set; }
        public DateTime VisitDateTime { get; set; }
        public DateTime RecordDateTime { get; set; }
    }
}
