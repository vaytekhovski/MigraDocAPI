using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class IncomeEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string description { get; set; }
    }
}
