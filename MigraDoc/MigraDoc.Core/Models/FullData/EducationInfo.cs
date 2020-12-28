using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class EducationInfo
    {
        public Guid Id { get; set; }
        public Guid EducationId { get; set; }
        public EducationInfoType type { get; set; }
        public string name { get; set; }
    }
}
