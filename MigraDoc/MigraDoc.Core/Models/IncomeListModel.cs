using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class IncomeListModel : IPersistentModel
    {
        public Guid id { get; set; }

        public IncomeModel MainIncome { get; set; }
        public IncomeModel OtherIncome { get; set; }
        public IncomeModel BankDeposit { get; set; }
        public IncomeModel Securities { get; set; }
        public IncomeModel SocialPayments { get; set; }
        public IncomeModel Other { get; set; }
    }
    

}
