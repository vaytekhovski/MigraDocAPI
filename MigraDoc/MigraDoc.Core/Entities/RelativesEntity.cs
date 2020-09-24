using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class RelativesEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public UserEntity UserEntity { get; set; }
        public Guid UserId { get; set; }
        public KinsfolkType KinsfolkType { get; set; }
        public bool alive { get; set; }
        public ChildType ChildType { get; set; }
        public SexType SexType { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool MiddleNameAbsent { get; set; }
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Guid NationalityId { get; set; }
        public NationalityEntity Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public Guid CountryOfResidenceId { get; set; }
        public AddressEntity CountryOfResidence { get; set; }
        public string WorkOrStudyPosition { get; set; }
        public string WorkOrStudyOrganizationName { get; set; }

    }
}
