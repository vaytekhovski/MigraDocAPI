using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class IncomeListConverter : IConverter<IncomeListEntity, IncomeListModel>
    {
        IncomeConverter incomeConverter = new IncomeConverter();
        public IncomeListModel entityToModel(IncomeListEntity entity, IncomeListModel model)
        {
            if (model == null)
            {
                model = new IncomeListModel();
            }

            model.id = entity.id;
            if(entity.MainIncome != null)
            {
                model.MainIncome = incomeConverter.entityToModel(entity.MainIncome, null);
            }

            if(entity.OtherIncome != null)
            {
                model.OtherIncome = incomeConverter.entityToModel(entity.OtherIncome, null);
            }

            if(entity.BankDeposit != null)
            {
                model.BankDeposit = incomeConverter.entityToModel(entity.BankDeposit, null);
            }

            if(entity.Securities != null)
            {
                model.Securities = incomeConverter.entityToModel(entity.Securities, null);
            }

            if(entity.SocialPayments != null)
            {
                model.SocialPayments = incomeConverter.entityToModel(entity.SocialPayments, null);
            }

            if(entity.Other != null)
            {
                model.Other = incomeConverter.entityToModel(entity.Other, null);
            }

            return model;
        }

        public IncomeListEntity modelToEntity(IncomeListEntity entity, IncomeListModel model)
        {
            if (entity == null)
            {
                entity = new IncomeListEntity();
            }

            if (model.MainIncome != null)
            {
                entity.MainIncome = incomeConverter.modelToEntity(null, model.MainIncome);
            }

            if (model.OtherIncome != null)
            {
                entity.OtherIncome = incomeConverter.modelToEntity(null, model.OtherIncome);
            }

            if (model.BankDeposit != null)
            {
                entity.BankDeposit = incomeConverter.modelToEntity(null, model.BankDeposit);
            }

            if (model.Securities != null)
            {
                entity.Securities = incomeConverter.modelToEntity(null, model.Securities);
            }

            if (model.SocialPayments != null)
            {
                entity.SocialPayments = incomeConverter.modelToEntity(null, model.SocialPayments);
            }

            if (model.Other != null)
            {
                entity.Other = incomeConverter.modelToEntity(null, model.Other);
            }

            return entity;
        }
    }
}
