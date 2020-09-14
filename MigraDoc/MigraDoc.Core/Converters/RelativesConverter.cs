using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class RelativesConverter : IConverter<RelativesEntity, RelativesModel>
    {
        NationalityConverter NationalityConverter = new NationalityConverter();
        AddressConverter AddressConverter = new AddressConverter();
        public RelativesModel entityToModel(RelativesEntity entity, RelativesModel model)
        {
            if (model == null)
            {
                model = new RelativesModel();
            }

            model.id = entity.id;
            model.UserId = entity.UserId;
            model.HusbandOrWifeExist = entity.HusbandOrWifeExist;
            model.HusbandOrWifeAlive = entity.HusbandOrWifeAlive;

            model.ChildExist = entity.ChildExist;
            model.ChildAlive = entity.ChildAlive;
            model.ChildType = entity.ChildType;

            model.FirstName = entity.FirstName;
            model.Surname = entity.Surname;
            model.MiddleName = entity.MiddleName;
            model.MiddleNameAbsent = entity.MiddleNameAbsent;

            model.DateOfBirth = entity.DateOfBirth;
            
            if(entity.Nationality != null)
            {
                model.Nationality = NationalityConverter.entityToModel(entity.Nationality, null);
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
            entity.HusbandOrWifeExist = model.HusbandOrWifeExist;
            entity.HusbandOrWifeAlive = model.HusbandOrWifeAlive;

            entity.ChildExist = model.ChildExist;
            entity.ChildAlive = model.ChildAlive;
            entity.ChildType = model.ChildType;

            entity.FirstName = model.FirstName;
            entity.Surname = model.Surname;
            entity.MiddleName = model.MiddleName;
            entity.MiddleNameAbsent = model.MiddleNameAbsent;

            entity.DateOfBirth = model.DateOfBirth;

            if (model.Nationality != null)
            {
                entity.Nationality = NationalityConverter.modelToEntity(null, model.Nationality);
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
