using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class RussianKnowledgeConverter : IConverter<RussianKnowledgeEntity, RussianKnowledgeModel>
    {
        public RussianKnowledgeModel entityToModel(RussianKnowledgeEntity entity, RussianKnowledgeModel model)
        {
            if (model == null)
            {
                model = new RussianKnowledgeModel();
            }

            model.id = entity.id;
            model.SertificateName = entity.SertificateName;
            model.rf = entity.rf;
            model.ussr = entity.ussr;
            return model;
        }

        public RussianKnowledgeEntity modelToEntity(RussianKnowledgeEntity entity, RussianKnowledgeModel model)
        {
            if (entity == null)
            {
                entity = new RussianKnowledgeEntity();
            }

            entity.SertificateName = model.SertificateName;
            entity.rf = model.rf;
            entity.ussr = model.ussr;
            return entity;
        }
    }
}
