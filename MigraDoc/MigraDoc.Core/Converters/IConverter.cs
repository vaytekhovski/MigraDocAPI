using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    public interface IConverter<TEntity, TModel>
        where TEntity : IPersistentEntity
        where TModel : IPersistentModel
    {
        TModel entityToModel(TEntity entity, TModel model);

        TEntity modelToEntity(TEntity entity, TModel model);
    }
}
