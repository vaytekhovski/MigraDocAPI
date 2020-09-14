using MigraDoc.Core.Entities;
using MigraDoc.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Converters
{
    class EducationLevelConverter : IConverter<EducationLevelEntity, EducationLevelModel>
    {
        public EducationLevelModel entityToModel(EducationLevelEntity entity, EducationLevelModel model)
        {
            if (model == null)
            {
                model = new EducationLevelModel();
            }

            model.id = entity.id;
            model.Doshkolnoe = entity.Doshkolnoe;
            model.NachalnoeObshee = entity.NachalnoeObshee;
            model.OsnovnoeObshee = entity.OsnovnoeObshee;
            model.SredneeObshee = entity.SredneeObshee;
            model.SredneeProfessionalnoe = entity.SredneeProfessionalnoe;
            model.VissheeBakalavriat = entity.VissheeBakalavriat;
            model.VissheeSpecialitetMagistratura = entity.VissheeSpecialitetMagistratura;
            model.VissheePodgotovkaKadrov = entity.VissheePodgotovkaKadrov;
            model.KandidatNauk = entity.KandidatNauk;
            model.DoktorNauk = entity.DoktorNauk;

            return model;
        }

        public EducationLevelEntity modelToEntity(EducationLevelEntity entity, EducationLevelModel model)
        {
            if (entity == null)
            {
                entity = new EducationLevelEntity();
            }
            entity.Doshkolnoe = model.Doshkolnoe;
            entity.NachalnoeObshee = model.NachalnoeObshee;
            entity.OsnovnoeObshee = model.OsnovnoeObshee;
            entity.SredneeObshee = model.SredneeObshee;
            entity.SredneeProfessionalnoe = model.SredneeProfessionalnoe;
            entity.VissheeBakalavriat = model.VissheeBakalavriat;
            entity.VissheeSpecialitetMagistratura = model.VissheeSpecialitetMagistratura;
            entity.VissheePodgotovkaKadrov = model.VissheePodgotovkaKadrov;
            entity.KandidatNauk = model.KandidatNauk;
            entity.DoktorNauk = model.DoktorNauk;

            return entity;
        }
    }
}
