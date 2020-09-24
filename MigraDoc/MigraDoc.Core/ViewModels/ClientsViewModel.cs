using MigraDoc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.ViewModels
{
    public class ClientsViewModel
    {
        public ClientsViewModel()
        {
            Users = new List<UserDataEntity>();
            filter = new ClientsFilterPanel();

        }
        public List<UserDataEntity> Users { get; set; }
        public ClientsFilterPanel filter { get; set; }
    }
}
