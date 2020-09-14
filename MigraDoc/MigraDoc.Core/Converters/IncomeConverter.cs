using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class IncomeConverter : IConverter<IncomeEntity, IncomeModel>
    {
        public IncomeModel entityToModel(IncomeEntity entity, IncomeModel model)
        {
            if (model == null)
            {
                model = new IncomeModel();
            }

            model.id = entity.id;
            model.amount = entity.amount;
            model.currency = entity.currency;
            model.description = entity.description;

            return model;
        }

        public IncomeEntity modelToEntity(IncomeEntity entity, IncomeModel model)
        {
            if (entity == null)
            {
                entity = new IncomeEntity();
            }

            entity.amount = model.amount;
            entity.currency = model.currency;
            entity.description = model.description;
            return entity;
        }
    }
}
