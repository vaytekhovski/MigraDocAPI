using System;
using System.Collections.Generic;
using System.Text;

namespace MigraDoc.Core.Entities
{
    public class EducationLevelEntity : IPersistentEntity
    {
        public Guid id { get; set; }
        public bool Doshkolnoe { get; set; }
        public bool NachalnoeObshee { get; set; }
        public bool OsnovnoeObshee { get; set; }
        public bool SredneeObshee { get; set; }
        public bool SredneeProfessionalnoe { get; set; }
        public bool VissheeBakalavriat { get; set; }
        public bool VissheeSpecialitetMagistratura { get; set; }
        public bool VissheePodgotovkaKadrov { get; set; }
        public bool KandidatNauk { get; set; }
        public bool DoktorNauk { get; set; }
    }
}
