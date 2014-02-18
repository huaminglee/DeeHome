using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiHaoOA.DataContract.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNumber { get; set; }
        public string ContactPerson2 { get; set; }
        public string ContactPerson2Number { get; set; }
        public string ContactPerson3 { get; set; }
        public string Contactperson3Number { get; set; }
        public string City { get; set; }
        public string UsableArea { get; set; }
        public string Email { get; set; }
        public string DecorationAddress { get; set; }
        public string RidePath { get; set; }
        public string AppointDateTime { get; set; }
        public string ProviderType { get; set; }
        public string CustomerType { get; set; }
        public string Comments { get; set; }
        public string WorkPlace { get; set; }
        public InformationAssistant InformationAssistants { get; set; }
        public Employee Employees { get; set; }
    }
}
