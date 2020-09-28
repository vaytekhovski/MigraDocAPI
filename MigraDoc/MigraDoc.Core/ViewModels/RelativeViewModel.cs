using MigraDoc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.ViewModels
{
    public class RelativeViewModel
    {
        public UserDataEntity UserData { get; set; }
        public RelativesEntity Relative { get; set; }
        
        public Guid RelativeId { get; set; }
        public Guid DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentStatus { get; set; }
        public string DocumentDate { get; set; }
        public string DocumentBase { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
