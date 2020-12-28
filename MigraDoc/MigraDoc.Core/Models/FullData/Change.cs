using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Change
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string changedFirstName { get; set; }
        public string changedSurname { get; set; }
        public string changedSecondName { get; set; }
        public ChangeType type { get; set; }
        public ChangeReason reason { get; set; }
        public int year { get; set; }
    }
}
