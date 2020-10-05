using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class CitizenshipConverter : IConverter<CitizenshipEntity, CitizenshipModel>
    {
        public CitizenshipModel entityToModel(CitizenshipEntity entity, CitizenshipModel model)
        {
            if (model == null)
            {
                model = new CitizenshipModel();
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

        public CitizenshipEntity modelToEntity(CitizenshipEntity entity, CitizenshipModel model)
        {
            if (entity == null)
            {
                entity = new CitizenshipEntity();
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
