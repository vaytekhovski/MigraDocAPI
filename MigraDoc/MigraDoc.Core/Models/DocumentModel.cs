using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class DocumentModel : IPersistentModel
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DocumentStatusType Status { get; set; }
        public string DocumentBase { get; set; }
        public DateTime Date { get; set; }
        public string AdditionalInfo { get; set; }


    }
}
