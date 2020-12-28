using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Passport
    {
        public Guid Id { get; set; }
        public string issuingCountry { get; set; }
        public string serie { get; set; }
        public string number { get; set; }
        public DateTime issueDate { get; set; }
        public string issuingPlace { get; set; }
        public DateTime validity { get; set; }
    }
}
