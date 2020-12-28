using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class Kinsfolk
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public KinsfolkType type { get; set; }
        public bool alive { get; set; }
        public Sex sex { get; set; }
        public ChildType childType { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string surname { get; set; }
        public string countryOfBirth { get; set; }
        public string areOfBirth { get; set; }
        public string cityOfBirth { get; set; }
        public string regionOfBirth { get; set; }
        public Guid workId { get; set; }
        public KinsfolkWork work { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }
        public string citizenship { get; set; }
        public Guid addressId { get; set; }
        public Address address { get; set; }
        public int yearOfDeath { get; set; }
        public string placeOfWorkOrStudy { get; set; }
        public string positionOrSpeciality { get; set; }
        public string childNameAndOrganizationNumber { get; set; }
    }
}
