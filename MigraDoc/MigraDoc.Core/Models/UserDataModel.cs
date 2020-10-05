﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class UserDataModel : IPersistentModel
    {
        public Guid id { get; set; }
        public UserModel UserModel { get; set; } 
        public SexType Sex { get; set; }
        public EducationModel Education { get; set; }
        public List<NameChangesModel> NameChanges { get; set; }
        public List<DocumentModel> Documents { get; set; }
        public DateTime UpdateDate { get; set; }


        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public string EngFirstName { get; set; }
        public string EngSurname { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }


        public CitizenshipModel Citizenship { get; set; }
        public string Nationality { get; set; }

        public string Creed { get; set; }
        public FamilyStatusModel FamilyStatus { get; set; }
        public IdentityDocumentModel IdentityDocument { get; set; }

        public List<RelativesModel> Relatives { get; set; }
        public List<WorkModel> Works { get; set; }
        public EducationLevelModel EducationLevel { get; set; }
        public WorkPermitModel WorkPermit { get; set; }
        public IncomeListModel Income { get; set; }
        public UnreleasedConvictionModel UnreleasedConviction { get; set; }
        public AddressModel ResidenceAddress { get; set; }
        public RussianKnowledgeModel RussianKnowledge { get; set; }

    }
}
