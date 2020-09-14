using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class UserEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public string telegramUserId { get; set; }
    }
}
