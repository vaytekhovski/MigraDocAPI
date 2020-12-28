using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Education
    {
        public Guid Id { get; set; }
        public EducationType type { get; set; }
        public string educationOrgName { get; set; }
        public int educationEndYear { get; set; }
        public string diplomaNumber { get; set; }
        public DateTime diplomaDate { get; set; }
        public string educationCity { get; set; }
        public List<EducationInfo> infoAboutProf { get; set; }
    }
}
