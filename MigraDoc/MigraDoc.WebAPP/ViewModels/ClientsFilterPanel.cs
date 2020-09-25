using Microsoft.AspNetCore.Mvc.Rendering;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.WebAPP.ViewModels
{
    public class ClientsFilterPanel
    {
        public ClientsFilterPanel()
        {
            country = "none";
            documentStatus = "all";
            documentType = "none";
            sex = "none";
            changedName = "none";
            orderBy = "new";
        }

        public string country { get; set; }
        public string documentType { get; set; }
        public string documentStatus { get; set; }
        public string sex { get; set; }
        public string changedName { get; set; }
        public string orderBy { get; set; }

        public List<SelectListItem> Countrys { get; set; }
        public List<SelectListItem> DocumentTypes { get; set; }
        public List<SelectListItem> DocumentStatuses { get; set; }
        public List<SelectListItem> Sexs { get; set; }
        public List<SelectListItem> ChangedNames { get; set; }
        public List<SelectListItem> OrderBy { get; set; }
    }
}
