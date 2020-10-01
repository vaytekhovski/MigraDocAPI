﻿using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class RussianKnowledgeEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string SertificateName { get; set; }
        public bool rf { get; set; }
        public bool ussr { get; set; }
    }
}
