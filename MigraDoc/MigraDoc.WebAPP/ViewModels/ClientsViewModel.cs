using MigraDoc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.WebAPP.ViewModels
{
    public class ClientsViewModel
    {
        public ClientsViewModel()
        {
            Users = new List<UserDataViewModel>();
            filter = new ClientsFilterPanel();

        }
        public List<UserDataViewModel> Users { get; set; }
        public ClientsFilterPanel filter { get; set; }
    }
}
