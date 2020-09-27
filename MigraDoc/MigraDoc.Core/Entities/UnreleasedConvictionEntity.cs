using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class UnreleasedConvictionEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public string Term { get; set; }
        public DateTime EndDate { get; set; }
    }
}
