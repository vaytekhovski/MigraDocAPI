using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Document
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DocumentType documentType { get; set; }
        public DocumentStatus documentStatus { get; set; }
        public DateTime creationDate { get; set; }
    }
}
