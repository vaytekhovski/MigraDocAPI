using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class WorkFromWho
    {
        public Guid Id { get; set; }
        public WorkForWhoType type { get; set; }
        public string positionName { get; set; }
        public DateTime workPeriod { get; set; }
    }
}
