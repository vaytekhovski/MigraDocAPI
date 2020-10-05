﻿using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class RelativesEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public UserEntity UserEntity { get; set; }
        public Guid UserId { get; set; }
        public KinsfolkType KinsfolkType { get; set; }
        [NotMapped]
        public string RelativeType { get; set; }
        public bool alive { get; set; }
        public ChildType ChildType { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Guid CitizenshipId { get; set; }
        public CitizenshipEntity Citizenship { get; set; }
        public string PlaceOfBirth { get; set; }
        public Guid CountryOfResidenceId { get; set; }
        public AddressEntity CountryOfResidence { get; set; }
        public string WorkOrStudyPosition { get; set; }
        public string WorkOrStudyOrganizationName { get; set; }

    }
}
