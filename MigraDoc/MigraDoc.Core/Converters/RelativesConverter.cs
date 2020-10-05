using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class RelativesConverter : IConverter<RelativesEntity, RelativesModel>
    {
        CitizenshipConverter CitizenshipConverter = new CitizenshipConverter();
        AddressConverter AddressConverter = new AddressConverter();
        public RelativesModel entityToModel(RelativesEntity entity, RelativesModel model)
        {
            if (model == null)
            {
                model = new RelativesModel();
            }

            model.id = entity.id;
            model.UserId = entity.UserId;
            model.KinsfolkType = entity.KinsfolkType;
            model.alive = entity.alive;
            model.ChildType = entity.ChildType;

            model.FirstName = entity.FirstName;
            model.Surname = entity.Surname;
            model.MiddleName = entity.MiddleName;

            model.DateOfBirth = entity.DateOfBirth;
            
            if(entity.Citizenship != null)
            {
                model.Citizenship = CitizenshipConverter.entityToModel(entity.Citizenship, null);
            }

            model.PlaceOfBirth = entity.PlaceOfBirth;

            if(entity.CountryOfResidence != null)
            {
                model.CountryOfResidence = AddressConverter.entityToModel(entity.CountryOfResidence, null);
            }

            model.WorkOrStudyPosition = entity.WorkOrStudyPosition;
            model.WorkOrStudyOrganizationName = entity.WorkOrStudyOrganizationName;

            return model;
        }

        public RelativesEntity modelToEntity(RelativesEntity entity, RelativesModel model)
        {
            if (entity == null)
            {
                entity = new RelativesEntity();
            }

            entity.UserId = model.UserId;
            entity.KinsfolkType = model.KinsfolkType;
            entity.alive = model.alive;
            entity.ChildType = model.ChildType;

            entity.FirstName = model.FirstName;
            entity.Surname = model.Surname;
            entity.MiddleName = model.MiddleName;

            entity.DateOfBirth = model.DateOfBirth;

            if (model.Citizenship != null)
            {
                entity.Citizenship = CitizenshipConverter.modelToEntity(null, model.Citizenship);
            }

            entity.PlaceOfBirth = model.PlaceOfBirth;

            if (model.CountryOfResidence != null)
            {
                entity.CountryOfResidence = AddressConverter.modelToEntity(null, model.CountryOfResidence);
            }

            entity.WorkOrStudyPosition = model.WorkOrStudyPosition;
            entity.WorkOrStudyOrganizationName = model.WorkOrStudyOrganizationName;

            return entity;
        }
    }
}
