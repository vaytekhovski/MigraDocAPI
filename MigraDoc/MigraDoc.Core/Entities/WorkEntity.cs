using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class WorkEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string Position { get; set; }
        public string OrganizationName { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public Guid AddressId { get; set; }
        public AddressEntity Address { get; set; }
    }
}
