using Com.SNGJob.Core.Exceptions;
using Microsoft.EntityFrameworkCore;
using MigraDoc.Core.Models;
using MigraDoc.Core.Models.FullData;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraDoc.Core.CRUD
{
    public class UserDataRepository
    {
        public async Task<User> CreateUser(string tgId)
        {
            using DatabaseContext db = new DatabaseContext();
            var user = await db.Users.FirstOrDefaultAsync(x => x.tgId == tgId);

            if (user != null)
            {
                throw new UserCreateFailedException();
            }
            else
            {
                user = new User();
            }

            user.tgId = tgId;
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return user;
        }


        public async Task<UserDetail> UpdateUserDetail(UserDetail model)
        {
            using DatabaseContext db = new DatabaseContext();
            db.UserDetails.Update(model);
            await db.SaveChangesAsync();
            return model;
        }

        public async Task<UserDetail> GetUserDetail(string tgId)
        {
            using DatabaseContext db = new DatabaseContext();
            var entity = await db.UserDetails.Include(x => x.User).FirstOrDefaultAsync(x => x.User.tgId == tgId);

            if (entity == null)
            {
                throw new UserNotFoundException();
            }

            return entity;
        }

        public async Task<List<ShortUserDetail>> GetListOfDocuments()
        {
            using DatabaseContext db = new DatabaseContext();
            List<ShortUserDetail> List = new List<ShortUserDetail>();

            foreach (var doc in await db.Documents.ToListAsync())
            {
                List.Add(new ShortUserDetail
                {
                    Document = doc,
                    UserId = doc.UserId,
                    FullName = await db.UserDetails.Where(x => x.UserId == doc.UserId).Include(x=>x.fullName).Select(x => x.fullName).FirstOrDefaultAsync()
                });
            }

            return List;

        }
    }
}
