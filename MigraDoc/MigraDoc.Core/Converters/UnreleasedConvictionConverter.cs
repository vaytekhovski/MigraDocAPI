using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class UnreleasedConvictionConverter : IConverter<UnreleasedConvictionEntity, UnreleasedConvictionModel>
    {
        public UnreleasedConvictionModel entityToModel(UnreleasedConvictionEntity entity, UnreleasedConvictionModel model)
        {
            if (model == null)
            {
                model = new UnreleasedConvictionModel();
            }

            model.id = entity.id;
            model.Place = entity.Place;
            model.StartDate = entity.StartDate;
            model.Term = entity.Term;
            model.EndDate = entity.EndDate;

            return model;
        }

        public UnreleasedConvictionEntity modelToEntity(UnreleasedConvictionEntity entity, UnreleasedConvictionModel model)
        {
            if (entity == null)
            {
                entity = new UnreleasedConvictionEntity();
            }

            entity.Place = model.Place;
            entity.StartDate = model.StartDate;
            entity.Term = model.Term;
            entity.EndDate = model.EndDate;

            return entity;
        }
    }
}
