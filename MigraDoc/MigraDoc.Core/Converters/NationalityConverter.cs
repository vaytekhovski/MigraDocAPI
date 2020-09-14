using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class NationalityConverter : IConverter<NationalityEntity, NationalityModel>
    {
        public NationalityModel entityToModel(NationalityEntity entity, NationalityModel model)
        {
            if (model == null)
            {
                model = new NationalityModel();
            }

            model.id = entity.id;
            model.Name = entity.Name;
            model.Type = entity.Type;
            model.DateOfReceiving = entity.DateOfReceiving;
            model.DateIsUnknown = entity.DateIsUnknown;
            model.HandlyDateOfReceiving = entity.HandlyDateOfReceiving;
            model.PlaceOfReceiving = entity.PlaceOfReceiving;
            model.StatelessPerson = entity.StatelessPerson;
            model.LossCountry = entity.LossCountry;
            model.LossReason = entity.LossReason;
            model.LossDate = entity.LossDate;

            return model;
        }

        public NationalityEntity modelToEntity(NationalityEntity entity, NationalityModel model)
        {
            if (entity == null)
            {
                entity = new NationalityEntity();
            }


            entity.Name = model.Name;
            entity.Type = model.Type;
            entity.DateOfReceiving = model.DateOfReceiving;
            entity.DateIsUnknown = model.DateIsUnknown;
            entity.HandlyDateOfReceiving = model.HandlyDateOfReceiving;
            entity.PlaceOfReceiving = model.PlaceOfReceiving;
            entity.StatelessPerson = model.StatelessPerson;
            entity.LossCountry = model.LossCountry;
            entity.LossReason = model.LossReason;
            entity.LossDate = model.LossDate;
            return entity;
        }
    }
}
