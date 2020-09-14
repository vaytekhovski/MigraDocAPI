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
        public bool Present { get; set; }
    }
}
