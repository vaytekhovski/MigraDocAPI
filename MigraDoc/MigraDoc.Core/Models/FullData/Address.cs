using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Address
    {
        public Guid Id { get; set; }
        public string addressArrivalCountry { get; set; }
        public string addressArea { get; set; }
        public string addressCity { get; set; }
        public string addressRegion { get; set; }
        public string addressHamlet { get; set; }
        public string addressVillage { get; set; }
        public string addressStreet { get; set; }
        public string addressHouseNumber { get; set; }
        public string addressBuildingNumber { get; set; }
        public string addressFlatNumber { get; set; }
        public string addressPhone { get; set; }
    }
}
