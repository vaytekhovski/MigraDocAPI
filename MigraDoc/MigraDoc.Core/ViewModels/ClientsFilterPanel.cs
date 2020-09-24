using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.ViewModels
{
    public class ClientsFilterPanel
    {
        public string country { get; set; }
        public string documentType { get; set; }
        public DocumentStatusType documentStatus { get; set; }
        public SexType sex { get; set; }
        public bool changedName { get; set; }
        public bool newFirsts { get; set; }
    }
}
