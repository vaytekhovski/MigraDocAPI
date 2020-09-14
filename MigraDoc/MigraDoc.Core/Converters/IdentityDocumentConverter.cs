using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class IdentityDocumentConverter : IConverter<IdentityDocumentEntity, IdentityDocumentModel>
    {
        public IdentityDocumentModel entityToModel(IdentityDocumentEntity entity, IdentityDocumentModel model)
        {
            if (model == null)
            {
                model = new IdentityDocumentModel();
            }

            model.id = entity.id;
            model.Country = entity.Country;
            model.Series = entity.Series;
            model.Number = entity.Number;
            model.IssueDate = entity.IssueDate;
            model.IssueAgency = entity.IssueAgency;

            return model;
        }

        public IdentityDocumentEntity modelToEntity(IdentityDocumentEntity entity, IdentityDocumentModel model)
        {
            if (entity == null)
            {
                entity = new IdentityDocumentEntity();
            }


            entity.Country = model.Country;
            entity.Series = model.Series;
            entity.Number = model.Number;
            entity.IssueDate = model.IssueDate;
            entity.IssueAgency = model.IssueAgency;

            return entity;
        }
    }
}
