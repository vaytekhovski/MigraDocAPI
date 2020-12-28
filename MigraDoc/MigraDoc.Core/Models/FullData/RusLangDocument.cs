using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class RusLangDocument
    {
        public Guid Id { get; set; }
        public RusLangDoc type { get; set; }
        public string serie { get; set; }
        public string number { get; set; }
        public DateTime issueDate { get; set; }
    }
}
