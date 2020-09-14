using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class WorkModel : IPersistentModel
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string Position { get; set; }
        public string OrganizationName { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public AddressModel Address { get; set; }
    }
}
