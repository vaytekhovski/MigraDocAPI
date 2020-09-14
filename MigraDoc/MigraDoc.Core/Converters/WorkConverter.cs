using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class WorkConverter : IConverter<WorkEntity, WorkModel>
    {
        AddressConverter AddressConverter = new AddressConverter();
        public WorkModel entityToModel(WorkEntity entity, WorkModel model)
        {
            if (model == null)
            {
                model = new WorkModel();
            }

            model.id = entity.id;
            model.UserId = entity.UserId;
            model.Position = entity.Position;
            model.OrganizationName = entity.OrganizationName;
            model.Start = entity.Start;
            model.End = entity.End;
            if(entity.Address != null)
            {
                model.Address = AddressConverter.entityToModel(entity.Address, null);
            }

            return model;
        }

        public WorkEntity modelToEntity(WorkEntity entity, WorkModel model)
        {
            if (entity == null)
            {
                entity = new WorkEntity();
            }

            entity.UserId = model.UserId;
            entity.Position = model.Position;
            entity.OrganizationName = model.OrganizationName;
            entity.Start = model.Start;
            entity.End = model.End;
            if (model.Address != null)
            {
                entity.Address = AddressConverter.modelToEntity(null, model.Address);
            }


            return entity;
        }
    }
}
