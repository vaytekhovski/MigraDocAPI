using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class DocumentEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public UserEntity UserEntity { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DocumentStatusType Status { get; set; }
        public string DocumentBase { get; set; }
        public DateTime Date { get; set; }

    }
}
