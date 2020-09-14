using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class NameChangesConverter : IConverter<NameChangesEntity, NameChangesModel>
    {
        public NameChangesModel entityToModel(NameChangesEntity entity, NameChangesModel model)
        {
            if (model == null)
            {
                model = new NameChangesModel();
            }

            model.id = entity.id;
            model.UserId = entity.UserId;
            model.PreviusFirstName = entity.PreviusFirstName;
            model.PreviusSurname = entity.PreviusSurname;
            model.PreviusMiddleName = entity.PreviusMiddleName;
            model.ChangeReason = entity.ChangeReason;
            model.ChangeDate = entity.ChangeDate;

            return model;
        }

        public NameChangesEntity modelToEntity(NameChangesEntity entity, NameChangesModel model)
        {
            if (entity == null)
            {
                entity = new NameChangesEntity();
            }

            entity.UserId = model.UserId;
            entity.PreviusFirstName = model.PreviusFirstName;
            entity.PreviusSurname = model.PreviusSurname;
            entity.PreviusMiddleName = model.PreviusMiddleName;
            entity.ChangeReason = model.ChangeReason;
            entity.ChangeDate = model.ChangeDate;

            return entity;
        }
    }
}
