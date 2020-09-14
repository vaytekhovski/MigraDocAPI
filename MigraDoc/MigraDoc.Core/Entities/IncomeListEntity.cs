using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class IncomeListEntity : IPersistentEntity
    {
        public Guid id { get; set; }

        public Guid MainIncomeId { get; set; }
        public IncomeEntity MainIncome { get; set; }
        public Guid OtherIncomeId { get; set; }
        public IncomeEntity OtherIncome { get; set; }
        public Guid BankDepositId { get; set; }
        public IncomeEntity BankDeposit { get; set; }
        public Guid SecuritiesId { get; set; }
        public IncomeEntity Securities { get; set; }
        public Guid SocialPaymentsId { get; set; }
        public IncomeEntity SocialPayments { get; set; }
        public Guid OtherId { get; set; }
        public IncomeEntity Other { get; set; }
    }
    

}
