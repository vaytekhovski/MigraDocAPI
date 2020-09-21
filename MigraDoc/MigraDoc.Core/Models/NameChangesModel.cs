using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class NameChangesModel : IPersistentModel
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public string PreviusFirstName { get; set; }
        public string PreviusSurname { get; set; }
        public string PreviusMiddleName { get; set; }
        public ChangeReasonType ChangeReason { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
