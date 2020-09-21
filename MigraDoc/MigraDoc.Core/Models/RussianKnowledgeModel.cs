using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class RussianKnowledgeModel : IPersistentModel
    {
        public Guid id { get; set; }
        public string SertificateName { get; set; }
        public RussianKnowledgeType RussianKnowledge { get; set; }
    }
}
