using MigraDoc.Core.Models.FullData;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class ShortUserDetail
    {
        public Guid UserId { get; set; }
        public Document Document { get; set; }
        public FullName FullName { get; set; }
    }
}
