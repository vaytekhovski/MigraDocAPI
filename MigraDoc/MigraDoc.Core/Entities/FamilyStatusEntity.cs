using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class FamilyStatusEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public FamilyStatusType Type { get; set; }
        public string MarriageCertificateNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuePlace { get; set; }
    }
}
