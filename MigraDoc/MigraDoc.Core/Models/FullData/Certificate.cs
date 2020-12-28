using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Certificate
    {
        public Guid Id { get; set; }
        public string serie { get; set; }
        public string number { get; set; }
        public DateTime date { get; set; }
        public string place { get; set; }

    }
}
