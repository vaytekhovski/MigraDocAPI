using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    public class AddressConverter : IConverter<AddressEntity, AddressModel>
    {
        public AddressModel entityToModel(AddressEntity entity, AddressModel model)
        {
            if(model == null)
            {
                model = new AddressModel();
            }

            model.id = entity.id;
            model.index = entity.index;
            model.Country = entity.Country;
            model.Region = entity.Region;
            model.Sity = entity.Sity;
            model.District = entity.District;
            model.Street = entity.Street;
            model.Build = entity.Build;
            model.Housing = entity.Housing;
            model.Flat = entity.Flat;
            model.Phone = entity.Phone;
            model.Email = entity.Email;
            return model;
        }

        public AddressEntity modelToEntity(AddressEntity entity, AddressModel model)
        {
            if(entity == null)
            {
                entity = new AddressEntity();
            }

            entity.index = model.index;
            entity.Country = model.Country;
            entity.Region = model.Region;
            entity.Sity = model.Sity;
            entity.District = model.District;
            entity.Street = model.Street;
            entity.Build = model.Build;
            entity.Housing = model.Housing;
            entity.Build = model.Flat;
            entity.Phone = model.Phone;
            entity.Email = model.Email;

            return entity;
        }
    }
}
