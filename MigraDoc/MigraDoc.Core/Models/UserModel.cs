using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class UserModel : IPersistentModel
    {
        public Guid id { get; set; }
        public string telegramUserId { get; set; }
    }
}
