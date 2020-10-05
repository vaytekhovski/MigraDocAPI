using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class CitizenshipModel : IPersistentModel
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public CitizenshipType Type { get; set; }
        public DateTime DateOfReceiving { get; set; }
        public bool DateIsUnknown { get; set; }
        public string HandlyDateOfReceiving { get; set; }
        public string PlaceOfReceiving { get; set; }
        public bool StatelessPerson { get; set; }
        public string LossReason { get; set; }
        public string LossCountry { get; set; }
        public DateTime LossDate { get; set; }
    }
}
