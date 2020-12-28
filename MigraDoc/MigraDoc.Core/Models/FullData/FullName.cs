using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class FullName
    {
        public Guid Id { get; set; }
        public string firstName { get; set; }
        public string surname { get; set; }
        public string secondName { get; set; }
        public string engSurname { get; set; }
        public string engName { get; set; }
    }
}
