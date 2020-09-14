using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class FamilyStatusConverter : IConverter<FamilyStatusEntity, FamilyStatusModel>
    {
        public FamilyStatusModel entityToModel(FamilyStatusEntity entity, FamilyStatusModel model)
        {
            if (model == null)
            {
                model = new FamilyStatusModel();
            }

            model.id = entity.id;
            model.Type = entity.Type;
            model.MarriageCertificateNumber = entity.MarriageCertificateNumber;
            model.IssueDate = entity.IssueDate;
            model.IssuePlace = entity.IssuePlace;

            return model;
        }

        public FamilyStatusEntity modelToEntity(FamilyStatusEntity entity, FamilyStatusModel model)
        {
            if (entity == null)
            {
                entity = new FamilyStatusEntity();
            }


            entity.Type = model.Type;
            entity.MarriageCertificateNumber = model.MarriageCertificateNumber;
            entity.IssueDate = model.IssueDate;
            entity.IssuePlace = model.IssuePlace;

            return entity;
        }
    }
}
