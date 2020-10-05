using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class FamilyStatusModel : IPersistentModel
    {
        public Guid id { get; set; }
        public FamilyStatusType Type { get; set; }
        public string MarriageCertificateNumber { get; set; }

        public string MarriageCertificateSeries { get; set; }
        public string Court { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuePlace { get; set; }
    }
}
