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
            model.SertificateOrDiplomRF = entity.SertificateOrDiplomRF;
            model.SertificateOrDiplomDo1991 = entity.SertificateOrDiplomDo1991;
            return model;
        }

        public RussianKnowledgeEntity modelToEntity(RussianKnowledgeEntity entity, RussianKnowledgeModel model)
        {
            if (entity == null)
            {
                entity = new RussianKnowledgeEntity();
            }

            entity.SertificateName = model.SertificateName;
            entity.SertificateOrDiplomRF = model.SertificateOrDiplomRF;
            entity.SertificateOrDiplomDo1991 = model.SertificateOrDiplomDo1991;

            return entity;
        }
    }
}
