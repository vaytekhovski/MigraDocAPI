using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class UserConverter : IConverter<UserEntity, UserModel>
    {
        public UserModel entityToModel(UserEntity entity, UserModel model)
        {
            if (model == null)
            {
                model = new UserModel();
            }

            model.id = entity.id;
            model.telegramUserId = entity.telegramUserId;

            return model;
        }

        public UserEntity modelToEntity(UserEntity entity, UserModel model)
        {
            if (entity == null)
            {
                entity = new UserEntity();
            }
            entity.telegramUserId = model.telegramUserId;
            return entity;
        }
    }
}
