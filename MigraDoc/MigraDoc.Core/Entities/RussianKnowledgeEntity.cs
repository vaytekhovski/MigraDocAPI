using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class RussianKnowledgeEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string SertificateName { get; set; }
        public RussianKnowledgeType RussianKnowledge { get; set; }
    }
}
