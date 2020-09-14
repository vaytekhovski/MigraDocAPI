using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class WorkPermitModel : IPersistentModel
    {
        public Guid id { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiresDate { get; set; }
    }
}
