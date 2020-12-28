using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class MigrationCard
    {
        public Guid Id { get; set; }
        public string serie { get; set; }
        public string number { get; set; }
        public DateTime issuingDate { get; set; }
    }
}
