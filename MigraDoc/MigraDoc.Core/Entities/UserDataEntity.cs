using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class UserDataEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public UserEntity User { get; set; } 
        public SexType Sex { get; set; }
        public Guid EducationId { get; set; }
        public EducationEntity Education { get; set; }
        public List<NameChangesEntity> NameChanges { get; set; }
        public DateTime UpdateDate { get; set; }

        public List<DocumentEntity> Documents { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public bool MiddleNameAbsent { get; set; }

        public string EngFirstName { get; set; }
        public string EngSurname { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public Guid NationalityId { get; set; }
        public NationalityEntity Nationality { get; set; }
        public string Creed { get; set; }

        public Guid FamilyStatusId { get; set; }
        public FamilyStatusEntity FamilyStatus { get; set; }
        public Guid IdentityDocumentId { get; set; }
        public IdentityDocumentEntity IdentityDocument { get; set; }

        public List<RelativesEntity> Relatives { get; set; }
        public List<WorkEntity> Works { get; set; }
        public Guid EducationLevelId { get; set; }
        public EducationLevelEntity EducationLevel { get; set; }
        public Guid WorkPermitId { get; set; }
        public WorkPermitEntity WorkPermit { get; set; }
        public Guid IncomeId { get; set; }
        public IncomeListEntity Income { get; set; }
        public Guid UnreleasedConvictionId { get; set; }
        public UnreleasedConvictionEntity UnreleasedConviction { get; set; }
        public Guid ResidenceAddressId { get; set; }
        public AddressEntity ResidenceAddress { get; set; }
        public Guid RussianKnowledgeId { get; set; }
        public RussianKnowledgeEntity RussianKnowledge { get; set; }

    }
}
