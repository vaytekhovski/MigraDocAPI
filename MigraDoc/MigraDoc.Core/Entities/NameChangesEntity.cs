using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class NameChangesEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string PreviusFirstName { get; set; }
        public string PreviusSurname { get; set; }
        public string PreviusMiddleName { get; set; }
        public ChangeReasonType ChangeReason { get; set; }
        public int ChangeDate { get; set; }
    }
}
