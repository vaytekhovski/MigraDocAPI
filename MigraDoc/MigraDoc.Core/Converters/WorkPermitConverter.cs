using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class WorkPermitConverter : IConverter<WorkPermitEntity, WorkPermitModel>
    {
        public WorkPermitModel entityToModel(WorkPermitEntity entity, WorkPermitModel model)
        {
            if (model == null)
            {
                model = new WorkPermitModel();
            }

            model.id = entity.id;
            model.Series = entity.Series;
            model.Number = entity.Number;
            model.IssueDate = entity.IssueDate;
            model.ExpiresDate = entity.ExpiresDate;

            return model;
        }

        public WorkPermitEntity modelToEntity(WorkPermitEntity entity, WorkPermitModel model)
        {
            if (entity == null)
            {
                entity = new WorkPermitEntity();
            }

            entity.Series = model.Series;
            entity.Number = model.Number;
            entity.IssueDate = model.IssueDate;
            entity.ExpiresDate = model.ExpiresDate;

            return entity;
        }
    }
}
