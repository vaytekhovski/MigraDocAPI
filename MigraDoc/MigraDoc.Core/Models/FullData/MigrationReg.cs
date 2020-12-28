using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class MigrationReg
    {
        public Guid Id { get; set; }
        public DateTime issuingDate { get; set; }
        public DateTime validityDate { get; set; }
    }
}
