using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace MigraDoc.Core.Models.FullData
{
    public class UserDetail
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<Document> Documents { get; set; }
        public string authorityName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }
        public string citizenship { get; set; }
        public DateTime dateOfGetCitithenship { get; set; }
        public string nationality { get; set; }
        public string creed { get; set; }
        public Guid isChangeId { get; set; }
        public isChange isChange { get; set; }
        public List<Change> changes { get; set; }
        public Sex sex { get; set; }
        public Guid fullNameId { get; set; }
        public FullName fullName { get; set; }
        public Guid passportId { get; set; }
        public Passport passport { get; set; }
        public Guid addressId { get; set; }
        public Address address { get; set; }
        public Guid educationId { get; set; }
        public Education education { get; set; }
        public Degree degree { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        public List<Kinsfolk> kinsfolks { get; set; }
        public Guid migrationCardId { get; set; }
        public MigrationCard migrationCard { get; set; }
        public Guid rusLangDocumentId { get; set; }
        public RusLangDocument rusLangDocument { get; set; }
        public Guid certificateId { get; set; }
        public Certificate certificate { get; set; }
        public Guid workFromWhoId { get; set; }
        public WorkFromWho workFromWho { get; set; }
        public Guid migrationRegistrationId { get; set; }
        public MigrationReg migrationRegistration { get; set; }
        public Guid birthAddressId { get; set; }
        public Address birthAddress { get; set; }
        public List<AddressDuringWork> addressDuringWork { get; set; }
        public List<Work> works { get; set; }
    }

    public enum DocumentType
    {
        rvp,
        vnj,
        work
    }

    public enum DocumentStatus
    {
        NotStarted,
        InWork,
        Completed
    }
}
