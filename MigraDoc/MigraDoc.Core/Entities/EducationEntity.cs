using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class EducationEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public DateTime EndDate { get; set; }
        public string Sertificate { get; set; }
        public string SertificateNumber { get; set; }
        public string Qualification { get; set; }
        public string IssuePlace { get; set; }
        public DateTime IssueDate { get; set; }
        public string Profession { get; set; }
        public string Specialization { get; set; }
        public string Direction { get; set; }
        public bool Present { get; set; }
    }
}
