using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class UnreleasedConvictionModel : IPersistentModel
    {
        public Guid id { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public string Term { get; set; }
        public DateTime EndDate { get; set; }
    }
}
