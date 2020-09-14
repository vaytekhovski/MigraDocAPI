using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    public class EducationConverter : IConverter<EducationEntity, EducationModel>
    {
        public EducationModel entityToModel(EducationEntity entity, EducationModel model)
        {
            if (model == null)
            {
                model = new EducationModel();
            }

            model.id = entity.id;
            model.EndDate = entity.EndDate;
            model.Sertificate = entity.Sertificate;
            model.Present = entity.Present;

            return model;
        }

        public EducationEntity modelToEntity(EducationEntity entity, EducationModel model)
        {
            if (entity == null)
            {
                entity = new EducationEntity();
            }

            entity.EndDate = model.EndDate;
            entity.Sertificate = model.Sertificate;
            entity.Present = model.Present;

            return entity;
        }
    }
}
