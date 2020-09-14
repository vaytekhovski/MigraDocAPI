using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public interface IPersistentModel
    {
        Guid id { get; set; }
    }
}
