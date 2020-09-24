using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class IdentityDocumentEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string Country { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssueAgency { get; set; }
    }
}
