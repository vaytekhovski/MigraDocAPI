using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models
{
    public class RelativesModel : IPersistentModel
    {
        public Guid id { get; set; }
        public Guid UserId { get; set; }
        public bool HusbandOrWifeExist { get; set; }
        public bool HusbandOrWifeAlive { get; set; }

        public bool ChildExist { get; set; }
        public bool ChildAlive { get; set; }
        public ChildType ChildType { get; set; }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public bool MiddleNameAbsent { get; set; }
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public NationalityModel Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public AddressModel CountryOfResidence { get; set; }
        public string WorkOrStudyPosition { get; set; }
        public string WorkOrStudyOrganizationName { get; set; }

    }
}
