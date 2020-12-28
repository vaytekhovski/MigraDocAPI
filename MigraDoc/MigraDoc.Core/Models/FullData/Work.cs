using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Work
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string period { get; set; }
        public string position { get; set; }
        public string placeName { get; set; }
        public Guid addressId { get; set; }
        public WorkAddress address { get; set; }
    }
}
