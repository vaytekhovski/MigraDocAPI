using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public interface IPersistentEntity
    {
        Guid id { get; set; }
    }
}
