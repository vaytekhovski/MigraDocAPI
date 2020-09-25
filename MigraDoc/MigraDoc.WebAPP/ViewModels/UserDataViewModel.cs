using MigraDoc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.WebAPP.ViewModels
{
    public class UserDataViewModel
    {
        public UserDataEntity UserData { get; set; }
        public Guid DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentStatus { get; set; }
        public string DocumentDate { get; set; }
    }
}
