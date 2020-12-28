using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class KinsfolkWork
    {
        public Guid Id { get; set; }
        public KinsfolkWorkType type { get; set; }
        public string placeName { get; set; }
        public string position { get; set; }
    }
}
