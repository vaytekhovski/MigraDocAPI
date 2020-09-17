using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    public class UserDataConverter : IConverter<UserDataEntity, UserDataModel>
    {
        UserConverter UserConverter = new UserConverter();
        EducationConverter EducationConverter = new EducationConverter();
        NameChangesConverter NameChangesConverter = new NameChangesConverter();
        NationalityConverter NationalityConverter = new NationalityConverter();
        IdentityDocumentConverter IdentityDocumentConverter = new IdentityDocumentConverter();
        RelativesConverter RelativesConverter = new RelativesConverter();
        WorkConverter WorkConverter = new WorkConverter();
        EducationLevelConverter EducationLevelConverter = new EducationLevelConverter();
        WorkPermitConverter WorkPermitConverter = new WorkPermitConverter();
        IncomeListConverter IncomeListConverter = new IncomeListConverter();
        UnreleasedConvictionConverter UnreleasedConvictionConverter = new UnreleasedConvictionConverter();
        AddressConverter AddressConverter = new AddressConverter();
        RussianKnowledgeConverter RussianKnowledgeConverter = new RussianKnowledgeConverter();
        public UserDataModel entityToModel(UserDataEntity entity, UserDataModel model)
        {
            if (model == null)
            {
                model = new UserDataModel();
            }

            model.id = entity.id;
            if(entity.User != null)
            {
                model.UserModel = UserConverter.entityToModel(entity.User, null);
            }

            model.Sex = entity.Sex;
            if(entity.Education != null)
            {
                model.Education = EducationConverter.entityToModel(entity.Education, null);
            }

            if (entity.NameChanges != null)
            {
                if (model.NameChanges == null)
                    model.NameChanges = new List<NameChangesModel>();
                foreach (var nameChange in entity.NameChanges)
                {
                    model.NameChanges.Add(NameChangesConverter.entityToModel(nameChange, null));
                }
            }

            model.FirstName = entity.FirstName;
            model.Surname = entity.Surname;
            model.MiddleName = entity.MiddleName;
            model.MiddleNameAbsent = entity.MiddleNameAbsent;

            model.EngFirstName = entity.EngFirstName;
            model.EngSurname = entity.EngSurname;

            model.DateOfBirth = entity.DateOfBirth;
            model.CountryOfBirth = entity.CountryOfBirth;
            model.PlaceOfBirth = entity.PlaceOfBirth;

            if(entity.Nationality != null)
            {
                model.Nationality = NationalityConverter.entityToModel(entity.Nationality, null);
            }

            model.Creed = entity.Creed;

            if(entity.IdentityDocument != null)
            {
                model.IdentityDocument = IdentityDocumentConverter.entityToModel(entity.IdentityDocument, null);
            }

            if(entity.Relatives != null)
            {
                if (model.Relatives == null)
                    model.Relatives = new List<RelativesModel>();
                foreach (var relative in entity.Relatives)
                {
                    model.Relatives.Add(RelativesConverter.entityToModel(relative, null));
                }
               
            }

            if(entity.Works != null)
            {
                if (model.Works == null)
                    model.Works = new List<WorkModel>();
                foreach (var work in entity.Works)
                {
                    model.Works.Add(WorkConverter.entityToModel(work, null));
                }
            }

            if(entity.EducationLevel != null)
            {
                model.EducationLevel = EducationLevelConverter.entityToModel(entity.EducationLevel, null);
            }

            if(entity.WorkPermit != null)
            {
                model.WorkPermit = WorkPermitConverter.entityToModel(entity.WorkPermit, null);
            }

            if(entity.Income != null)
            {
                model.Income = IncomeListConverter.entityToModel(entity.Income, null);
            }

            if(entity.UnreleasedConviction != null)
            {
                model.UnreleasedConviction = UnreleasedConvictionConverter.entityToModel(entity.UnreleasedConviction, null);
            }

            if(entity.ResidenceAddress != null)
            {
                model.ResidenceAddress = AddressConverter.entityToModel(entity.ResidenceAddress, null);
            }

            if(entity.RussianKnowledge != null)
            {
                model.RussianKnowledge = RussianKnowledgeConverter.entityToModel(entity.RussianKnowledge, null);
            }

            return model;
        }

        public UserDataEntity modelToEntity(UserDataEntity entity, UserDataModel model)
        {
            if (entity == null)
            {
                entity = new UserDataEntity();
            }

            if (model.UserModel != null)
            {
                entity.User = UserConverter.modelToEntity(null, model.UserModel);
            }

            entity.Sex = model.Sex;
            if (model.Education != null)
            {
                entity.Education = EducationConverter.modelToEntity(null, model.Education);
            }

            if (model.NameChanges != null)
            {
                if (entity.NameChanges == null)
                    entity.NameChanges = new List<NameChangesEntity>();
                foreach (var nameChange in model.NameChanges)
                {
                    entity.NameChanges.Add(NameChangesConverter.modelToEntity(null, nameChange));
                }
            }

            entity.FirstName = model.FirstName;
            entity.Surname = model.Surname;
            entity.MiddleName = model.MiddleName;
            entity.MiddleNameAbsent = model.MiddleNameAbsent;

            entity.EngFirstName = model.EngFirstName;
            entity.EngSurname = model.EngSurname;

            entity.DateOfBirth = model.DateOfBirth;
            entity.CountryOfBirth = model.CountryOfBirth;
            entity.PlaceOfBirth = model.PlaceOfBirth;

            if (model.Nationality != null)
            {
                entity.Nationality = NationalityConverter.modelToEntity(null, model.Nationality);
            }

            entity.Creed = model.Creed;

            if (model.IdentityDocument != null)
            {
                entity.IdentityDocument = IdentityDocumentConverter.modelToEntity(null, model.IdentityDocument);
            }

            if (model.Relatives != null)
            {
                if (entity.Relatives == null)
                    entity.Relatives = new List<RelativesEntity>();
                foreach (var relative in model.Relatives)
                {
                    entity.Relatives.Add(RelativesConverter.modelToEntity(null, relative));
                }

            }

            if (model.Works != null)
            {
                if (entity.Works == null)
                    entity.Works = new List<WorkEntity>();
                foreach (var work in model.Works)
                {
                    entity.Works.Add(WorkConverter.modelToEntity(null, work));
                }
            }

            if (model.EducationLevel != null)
            {
                entity.EducationLevel = EducationLevelConverter.modelToEntity(null, model.EducationLevel);
            }

            if (model.WorkPermit != null)
            {
                entity.WorkPermit = WorkPermitConverter.modelToEntity(null, model.WorkPermit);
            }

            if (model.Income != null)
            {
                entity.Income = IncomeListConverter.modelToEntity(null, model.Income);
            }

            if (model.UnreleasedConviction != null)
            {
                entity.UnreleasedConviction = UnreleasedConvictionConverter.modelToEntity(null, model.UnreleasedConviction);
            }

            if (model.ResidenceAddress != null)
            {
                entity.ResidenceAddress = AddressConverter.modelToEntity(null, model.ResidenceAddress);
            }

            if (model.RussianKnowledge != null)
            {
                entity.RussianKnowledge = RussianKnowledgeConverter.modelToEntity(null, model.RussianKnowledge);
            }

            return entity;
        }
    }
}
