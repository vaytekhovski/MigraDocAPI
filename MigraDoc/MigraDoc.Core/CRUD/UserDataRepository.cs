using Com.SNGJob.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using MigraDoc.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MigraDoc.Core.CRUD
{
    public class UserDataRepository
    {
        public UserEntity CreateNewUser(UserEntity user)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var check_exist = db.Users
                    .AsNoTracking()
                    .Where(x => x.telegramUserId == user.telegramUserId)
                    .FirstOrDefault();

                if (check_exist != null)
                {
                    throw new TelegramUserAlreadyExistsException();
                }

                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();

                    var IncomeList = new IncomeListEntity()
                    {
                        MainIncome = new IncomeEntity(),
                        OtherIncome = new IncomeEntity(),
                        BankDeposit = new IncomeEntity(),
                        Securities = new IncomeEntity(),
                        SocialPayments = new IncomeEntity(),
                        Other = new IncomeEntity()
                    };

                    db.UserDatas.Add(new UserDataEntity
                    {
                        UserId = user.id,
                        Education = new EducationEntity(),
                        Nationality = new NationalityEntity(),
                        IdentityDocument = new IdentityDocumentEntity(),
                        EducationLevel = new EducationLevelEntity(),
                        WorkPermit = new WorkPermitEntity(),
                        Income = IncomeList,
                        UnreleasedConviction = new UnreleasedConvictionEntity(),
                        ResidenceAddress = new AddressEntity(),
                        RussianKnowledge = new RussianKnowledgeEntity(),
                        FamilyStatus = new FamilyStatusEntity()
                    });
                    db.SaveChanges();

                }
                catch (Exception e)
                {
                    throw new UserCreateFailedException();
                }
            }

            return user;
        }

        public UserDataEntity UpdateUserData(UserDataEntity userData)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var exist_user = db.Users
                    .Where(x => x.telegramUserId == userData.User.telegramUserId)
                    .FirstOrDefault();

                if (exist_user == null)
                {
                    throw new UserNotFoundException();
                }

                var exist_userdata = db.UserDatas
                    .Where(x => x.UserId == exist_user.id)
                    .FirstOrDefault();

                exist_userdata.User = exist_user;
                exist_userdata.Sex = userData.Sex;

                if (userData.Education != null)
                {
                    userData.Education.id = exist_userdata.EducationId;
                    exist_userdata.Education = userData.Education;
                    db.Educations.Update(exist_userdata.Education);
                }

                if(userData.FamilyStatus != null)
                {
                    userData.FamilyStatus.id = exist_userdata.FamilyStatusId;
                    exist_userdata.FamilyStatus = userData.FamilyStatus;
                    db.FamilyStatuses.Update(exist_userdata.FamilyStatus);
                }

                if (userData.NameChanges != null)
                {
                    foreach (var item in userData.NameChanges)
                    {
                        item.UserId = exist_user.id;
                    }
                    var items_to_remove = db.NameChanges.Where(x => x.UserId == exist_user.id).ToList();
                    db.NameChanges.RemoveRange(items_to_remove);
                    db.NameChanges.AddRange(userData.NameChanges);
                }

                exist_userdata.FirstName = userData.FirstName == null ? exist_userdata.FirstName : userData.FirstName;
                exist_userdata.Surname = userData.Surname == null ? exist_userdata.Surname : userData.Surname;
                exist_userdata.MiddleName = userData.MiddleName == null ? exist_userdata.MiddleName : userData.MiddleName;
                exist_userdata.MiddleNameAbsent = userData.MiddleName == null ? true : false;
                exist_userdata.EngFirstName = userData.EngFirstName == null ? exist_userdata.EngFirstName : userData.EngFirstName;
                exist_userdata.EngSurname = userData.EngSurname == null ? exist_userdata.EngSurname : userData.EngSurname;

                exist_userdata.DateOfBirth = userData.DateOfBirth.ToString() == "0001-01-01T00:00:00" ? exist_userdata.DateOfBirth : userData.DateOfBirth;
                exist_userdata.CountryOfBirth = userData.CountryOfBirth == null ? exist_userdata.CountryOfBirth : userData.CountryOfBirth;
                exist_userdata.PlaceOfBirth = userData.PlaceOfBirth == null ? exist_userdata.PlaceOfBirth : userData.PlaceOfBirth;

                if (userData.Nationality != null)
                {
                    userData.Nationality.id = exist_userdata.NationalityId;
                    exist_userdata.Nationality = userData.Nationality;
                    db.Nationalities.Update(exist_userdata.Nationality);
                }

                exist_userdata.Creed = userData.Creed == null ? exist_userdata.Creed : userData.Creed;

                if (userData.IdentityDocument != null)
                {
                    userData.IdentityDocument.id = exist_userdata.IdentityDocumentId;
                    exist_userdata.IdentityDocument = userData.IdentityDocument;
                    db.IdentityDocuments.Update(exist_userdata.IdentityDocument);

                }

                if (userData.Relatives != null)
                {
                    foreach (var item in userData.Relatives)
                    {
                        item.UserId = exist_user.id;
                    }
                    db.Relatives.UpdateRange(userData.Relatives);
                }

                if(userData.Documents != null)
                {
                    foreach (var item in userData.Documents)
                    {
                        item.UserDataEntityid = exist_userdata.id;
                        item.UserEntityid = exist_user.id;
                        item.UserId = exist_user.id;
                        //item.Date = DateTime.Now;
                    }

                    var items_to_remove = db.Documents.Where(x => x.UserId == exist_user.id).ToList();
                    db.Documents.RemoveRange(items_to_remove);
                    db.Documents.AddRange(userData.Documents);
                }

                if (userData.Works != null)
                {
                    foreach (var item in userData.Works)
                    {
                        item.UserId = exist_user.id;
                    }

                    var items_to_remove = db.Works.Where(x => x.UserId == exist_user.id).ToList();
                    db.Works.RemoveRange(items_to_remove);
                    db.Works.AddRange(userData.Works);
                }

                if (userData.EducationLevel != null)
                {
                    userData.EducationLevel.id = exist_userdata.EducationLevelId;
                    exist_userdata.EducationLevel = userData.EducationLevel;
                    db.EducationLevels.Update(exist_userdata.EducationLevel);

                }

                if (userData.WorkPermit != null)
                {
                    userData.WorkPermit.id = exist_userdata.WorkPermitId;
                    exist_userdata.WorkPermit = userData.WorkPermit;
                    db.WorkPermits.Update(exist_userdata.WorkPermit);

                }

                if (userData.Income != null)
                {
                    userData.Income.id = exist_userdata.IncomeId;
                    exist_userdata.Income = userData.Income;
                    db.IncomeLists.Update(exist_userdata.Income);

                }

                if (userData.UnreleasedConviction != null)
                {
                    userData.UnreleasedConviction.id = exist_userdata.UnreleasedConvictionId;
                    exist_userdata.UnreleasedConviction = userData.UnreleasedConviction;
                    db.UnreleasedConvictions.Update(exist_userdata.UnreleasedConviction);

                }

                if (userData.ResidenceAddress != null)
                {
                    userData.ResidenceAddress.id = exist_userdata.ResidenceAddressId;
                    exist_userdata.ResidenceAddress = userData.ResidenceAddress;
                    db.Addresses.Update(exist_userdata.ResidenceAddress);

                }

                if (userData.RussianKnowledge != null)
                {
                    userData.RussianKnowledge.id = exist_userdata.RussianKnowledgeId;
                    exist_userdata.RussianKnowledge = userData.RussianKnowledge;
                    db.RussianKnowledges.Update(exist_userdata.RussianKnowledge);

                }

                exist_userdata.UpdateDate = DateTime.Now;
                db.SaveChanges();
                userData = GetUserData(exist_user.telegramUserId);
            }

            return userData;
        }

        public UserDataEntity GetUserData(Guid UserId)
        {
            var userData = new UserDataEntity();
            using(DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .Where(x => x.id == UserId)
                    .FirstOrDefault();

                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                userData = GetUserData(user.telegramUserId);

            }

            return userData;
        }

        public UserDataEntity GetUserData(string tgUserId)
        {
            var userData = new UserDataEntity();
            using(DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .Where(x => x.telegramUserId == tgUserId)
                    .FirstOrDefault();

                if(user == null)
                {
                    throw new UserNotFoundException();
                }

                userData = db.UserDatas
                    .AsNoTracking()
                    .Where(x => x.UserId == user.id)
                    .FirstOrDefault();

                userData.User = user;

                userData.Documents = db.Documents.AsNoTracking().Where(x => x.UserId == userData.UserId).ToList();
                userData.Education = db.Educations.AsNoTracking().Where(x => x.id == userData.EducationId).FirstOrDefault();
                userData.NameChanges = db.NameChanges.AsNoTracking().Where(x => x.UserId == userData.UserId).ToList();
                userData.Nationality = db.Nationalities.AsNoTracking().Where(x => x.id == userData.NationalityId).FirstOrDefault();
                userData.IdentityDocument = db.IdentityDocuments.AsNoTracking().Where(x => x.id == userData.IdentityDocumentId).FirstOrDefault();
                userData.Relatives = db.Relatives.AsNoTracking().Include(x=>x.Nationality).Include(x=>x.CountryOfResidence).Where(x => x.UserId == userData.UserId).ToList();
                userData.Works = db.Works.AsNoTracking().Where(x => x.UserId == userData.UserId).ToList();
                userData.EducationLevel = db.EducationLevels.AsNoTracking().Where(x => x.id == userData.EducationLevelId).FirstOrDefault();
                userData.WorkPermit = db.WorkPermits.AsNoTracking().Where(x => x.id == userData.WorkPermitId).FirstOrDefault();
                userData.Income = db.IncomeLists.AsNoTracking().Where(x => x.id == userData.IncomeId).FirstOrDefault();
                userData.Income.MainIncome = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.MainIncomeId).FirstOrDefault();
                userData.Income.OtherIncome = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.OtherIncomeId).FirstOrDefault();
                userData.Income.BankDeposit = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.BankDepositId).FirstOrDefault();
                userData.Income.Securities = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.SecuritiesId).FirstOrDefault();
                userData.Income.SocialPayments = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.SocialPaymentsId).FirstOrDefault();
                userData.Income.Other = db.Incomes.AsNoTracking().Where(x => x.id == userData.Income.OtherId).FirstOrDefault();
                userData.UnreleasedConviction = db.UnreleasedConvictions.AsNoTracking().Where(x => x.id == userData.UnreleasedConvictionId).FirstOrDefault();
                userData.ResidenceAddress = db.Addresses.AsNoTracking().Where(x => x.id == userData.ResidenceAddressId).FirstOrDefault();
                userData.RussianKnowledge = db.RussianKnowledges.AsNoTracking().Where(x => x.id == userData.RussianKnowledgeId).FirstOrDefault();
                userData.FamilyStatus = db.FamilyStatuses.AsNoTracking().Where(x => x.id == userData.FamilyStatusId).FirstOrDefault();


            }

            return userData;
        }

        public Guid CreateRelative(Guid UserId)
        {
            Guid RelativeId = new Guid();
            using(DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .Where(x => x.id == UserId)
                    .FirstOrDefault();

                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                var Relative = new RelativesEntity
                {
                    UserId = UserId,
                    CountryOfResidence = new AddressEntity(),
                    Nationality = new NationalityEntity()

                };
                db.Relatives.Add(Relative);
                db.SaveChanges();
                RelativeId = Relative.id;
            }

            return RelativeId;
        }

        public Guid RemoveRelative(Guid RelativeId)
        {
            Guid UserId = new Guid();
            using (DatabaseContext db = new DatabaseContext())
            {
                var Relative = db.Relatives.Where(x => x.id == RelativeId).FirstOrDefault();
                if (Relative == null)
                {
                    throw new UserNotFoundException();
                }

                UserId = Relative.UserId;
                db.Relatives.Remove(Relative);
                db.SaveChanges();
            }
            return UserId;

        }

        public UserDataEntity GetUserRelative(Guid UserId)
        {
            var userData = new UserDataEntity();
            using (DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .Where(x => x.id == UserId)
                    .FirstOrDefault();

                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                userData = db.UserDatas
                    .AsNoTracking()
                    .Where(x => x.UserId == user.id)
                    .Include(x => x.User)
                    .Include(x => x.Relatives)
                    .Include(x => x.Nationality)
                    .Include(x => x.Documents)
                    .FirstOrDefault();

            }

            return userData;
        }

            public void RemoveUser(string tgUserId)
        {
            var userData = GetUserData(tgUserId);
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Documents.RemoveRange(userData.Documents);
                db.RussianKnowledges.Remove(userData.RussianKnowledge);
                db.Addresses.Remove(userData.ResidenceAddress);
                db.UnreleasedConvictions.Remove(userData.UnreleasedConviction);
                db.Incomes.Remove(userData.Income.Other);
                db.Incomes.Remove(userData.Income.SocialPayments);
                db.Incomes.Remove(userData.Income.Securities);
                db.Incomes.Remove(userData.Income.BankDeposit);
                db.Incomes.Remove(userData.Income.OtherIncome);
                db.Incomes.Remove(userData.Income.MainIncome);
                db.IncomeLists.Remove(userData.Income);
                db.WorkPermits.Remove(userData.WorkPermit);
                db.Works.RemoveRange(userData.Works);
                db.EducationLevels.Remove(userData.EducationLevel);
                db.Relatives.RemoveRange(userData.Relatives);
                db.IdentityDocuments.Remove(userData.IdentityDocument);
                db.Nationalities.Remove(userData.Nationality);
                db.NameChanges.RemoveRange(userData.NameChanges);
                db.Educations.RemoveRange(userData.Education);
                db.Users.Remove(userData.User);
                db.UserDatas.Remove(userData);
                db.FamilyStatuses.Remove(userData.FamilyStatus);
                db.SaveChanges();
            }
        }


        public List<UserDataEntity> GetUsers(ClientsFilterPanel filter)
        {
            var _UserDatas = new List<UserDataEntity>();
            //var UserDatas = new List<UserDataEntity>();

            using(DatabaseContext db = new DatabaseContext())
            {
                _UserDatas = db.UserDatas
                    .Include(x=>x.User)
                    .Include(x=>x.Nationality)
                    .Include(x=>x.Documents)
                    .Include(x=>x.NameChanges)
                    .ToList();

                if(filter.country != "none")
                {
                    _UserDatas = _UserDatas.Where(x => x.Nationality.Name == filter.country).ToList();
                }

                if(filter.documentStatus != "all")
                {
                    var DocumentStatus = new DocumentStatusType();
                    switch (filter.documentStatus)
                    {
                        case "all":
                            DocumentStatus = DocumentStatusType.none;
                            break;
                        case "new":
                            DocumentStatus = DocumentStatusType.NotStarted;
                            break;
                        case "inWork":
                            DocumentStatus = DocumentStatusType.InWork;
                            break;
                        case "closed":
                            DocumentStatus = DocumentStatusType.Complete;
                            break;

                        default:
                            break;
                    }
                    _UserDatas = _UserDatas.Where(x => x.Documents.FirstOrDefault(y => y.Status == DocumentStatus) != null).ToList();
                }

                if(filter.documentType != "none")
                {
                    _UserDatas = _UserDatas.Where(x => x.Documents.FirstOrDefault(y => y.Name == filter.documentType) != null).ToList();
                }

                if(filter.sex != "none")
                {
                    var sex = new SexType();
                    switch (filter.sex)
                    {
                        case "men":
                            sex = SexType.MEN;
                            break;
                        case "women":
                            sex = SexType.WOMEN;
                            break;
                        default:
                            break;
                    }
                    _UserDatas = _UserDatas.Where(x => x.Sex == sex).ToList();
                }

                if(filter.changedName != "none")
                {
                    _UserDatas = _UserDatas.Where(x => x.NameChanges != null).ToList();
                }

                /*
                foreach (var userDataEntity in _UserDatas)
                {
                    var UserData = GetUserData(userDataEntity.User.telegramUserId);
                    UserDatas.Add(UserData);
                }
                */



                if(filter.orderBy == "new")
                {
                    _UserDatas = _UserDatas.OrderByDescending(x => x.UpdateDate).ToList();
                }
                else
                {
                    _UserDatas = _UserDatas.OrderBy(x => x.UpdateDate).ToList();
                }
            }

            return _UserDatas;
        }

        public Guid ChangeUserDocumentStatus(Guid DocumentId)
        {
            Guid UserId = new Guid();
            using (DatabaseContext db = new DatabaseContext())
            {
                var document = db.Documents.Where(x => x.id == DocumentId).FirstOrDefault();

                if (document == null)
                {
                    throw new UserNotFoundException();
                }

                UserId = document.UserId;
                switch (document.Status)
                {
                    case DocumentStatusType.NotStarted:
                        document.Status = DocumentStatusType.InWork;
                        break;
                    case DocumentStatusType.InWork:
                        document.Status = DocumentStatusType.Complete;
                        break;
                    case DocumentStatusType.Complete:
                        break;
                    default:
                        break;
                }
                db.SaveChanges();

            }

            return UserId;
        }

        public DocumentEntity GetDocument(Guid DocumentId)
        {
            DocumentEntity document = new DocumentEntity();
            using(DatabaseContext db = new DatabaseContext())
            {
                document = db.Documents.AsNoTracking().FirstOrDefault(x => x.id == DocumentId);

                if(document == null)
                {
                    throw new UserNotFoundException();
                }
            }

            return document;
        }

        public void AddWork(Guid UserId)
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .Where(x => x.id == UserId)
                    .FirstOrDefault();

                if (user == null)
                {
                    throw new UserNotFoundException();
                }

                db.Works.Add(new WorkEntity
                {
                    Address = new AddressEntity(),
                    UserId = UserId
                });
                db.SaveChanges();
            }
        }
    }
}
