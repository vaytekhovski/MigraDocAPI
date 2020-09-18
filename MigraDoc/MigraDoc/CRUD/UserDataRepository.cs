using Com.SNGJob.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MigraDoc.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraDoc.WebAPI.CRUD
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
                        RussianKnowledge = new RussianKnowledgeEntity()
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
                    .AsNoTracking()
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

                if (userData.NameChanges != null)
                {
                    foreach (var item in userData.NameChanges)
                    {
                        item.UserId = exist_user.id;
                    }

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

                    db.Relatives.AddRange(userData.Relatives);
                }

                if (userData.Works != null)
                {
                    foreach (var item in userData.Works)
                    {
                        item.UserId = exist_user.id;
                    }

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


                db.SaveChanges();
                userData = exist_userdata;
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

                userData.Education = db.Educations.AsNoTracking().Where(x => x.id == userData.EducationId).FirstOrDefault();
                userData.NameChanges = db.NameChanges.AsNoTracking().Where(x => x.UserId == userData.UserId).ToList();
                userData.Nationality = db.Nationalities.AsNoTracking().Where(x => x.id == userData.NationalityId).FirstOrDefault();
                userData.IdentityDocument = db.IdentityDocuments.AsNoTracking().Where(x => x.id == userData.IdentityDocumentId).FirstOrDefault();
                userData.Relatives = db.Relatives.AsNoTracking().Where(x => x.UserId == userData.UserId).ToList();
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


            }

            return userData;
        }

        public void RemoveUser(string tgUserId)
        {
            var userData = GetUserData(tgUserId);
            using (DatabaseContext db = new DatabaseContext())
            {
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
                db.SaveChanges();
            }
        }

    }
}
