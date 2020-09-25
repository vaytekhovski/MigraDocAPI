﻿
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MigraDoc.Core.ViewModels
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

        public IEnumerable<SelectListItem> Countrys { get; set; }
        public IEnumerable<SelectListItem> DocumentTypes { get; set; }
        public IEnumerable<SelectListItem> DocumentStatuses { get; set; }
        public IEnumerable<SelectListItem> Sexs { get; set; }
        public IEnumerable<SelectListItem> ChangedNames { get; set; }
        public IEnumerable<SelectListItem> OrderBy { get; set; }
    }
}
