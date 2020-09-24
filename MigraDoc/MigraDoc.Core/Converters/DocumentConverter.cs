using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class DocumentConverter : IConverter<DocumentEntity, DocumentModel>
    {
        public DocumentModel entityToModel(DocumentEntity entity, DocumentModel model)
        {
            if (model == null)
            {
                model = new DocumentModel();
            }

            model.id = entity.id;
            model.UserId = entity.UserId;
            model.Name = entity.Name;
            model.Status = entity.Status;
            model.DocumentBase = entity.DocumentBase;
            model.Date = entity.Date;
            return model;
        }

        public DocumentEntity modelToEntity(DocumentEntity entity, DocumentModel model)
        {
            if (entity == null)
            {
                entity = new DocumentEntity();
            }
            entity.UserId = model.UserId;
            entity.Name = model.Name;
            entity.Status = model.Status;
            entity.DocumentBase = model.DocumentBase;
            entity.Date = model.Date;
            return entity;
        }
    }
}
