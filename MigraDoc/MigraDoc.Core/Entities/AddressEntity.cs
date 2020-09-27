using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class AddressEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string index { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Sity { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Build { get; set; }
        public string Housing { get; set; }
        public string Flat { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
