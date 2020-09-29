using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigraDoc.WebAPP.Models
{
    public class DropDowns
    {
        public static List<Field> Countrys = new List<Field>();
        public static List<Field> DocumentTypes = new List<Field>();
        public static List<Field> DocumentStatuses = new List<Field>();
        public static List<Field> Sexs = new List<Field>();
        public static List<Field> ChangedNames = new List<Field>();
        public static List<Field> OrderBy = new List<Field>();
        public static List<Field> RelativeTypes = new List<Field>();

        static DropDowns()
        {
            InitiateCountrys();
            InitiateDocumentTypes();
            InitiateDocumentStatuses();
            InitiateSexs();
            InitiateChangedNames();
            InitiateOrderBy();
            InitiateRelativeTypes();
        }

        private static void InitiateRelativeTypes()
        {
            RelativeTypes.Add(new Field { Value = "Муж", Name = "Муж" });
            RelativeTypes.Add(new Field { Value = "Жена", Name = "Жена" });
            RelativeTypes.Add(new Field { Value = "Сын", Name = "Сын" });
            RelativeTypes.Add(new Field { Value = "Дочь", Name = "Дочь" });
            RelativeTypes.Add(new Field { Value = "Мать", Name = "Мать" });
            RelativeTypes.Add(new Field { Value = "Отец", Name = "Отец" });
            RelativeTypes.Add(new Field { Value = "Брат", Name = "Брат" });
            RelativeTypes.Add(new Field { Value = "Сестра", Name = "Сестра" });
        }

        private static void InitiateOrderBy()
        {
            OrderBy.Add(new Field { Value = "new", Name = "Сначала новые" });
            OrderBy.Add(new Field { Value = "old", Name = "Сначала старые" });
        }

        private static void InitiateChangedNames()
        {
            ChangedNames.Add(new Field { Value = "none", Name = "Изменение ФИО" });
            ChangedNames.Add(new Field { Value = "true", Name = "ФИО менялись" });
            ChangedNames.Add(new Field { Value = "false", Name = "ФИО не менялись" });
        }

        private static void InitiateSexs()
        {
            Sexs.Add(new Field { Value = "none", Name = "Выбор пола" });
            Sexs.Add(new Field { Value = "men", Name = "Мужчина" });
            Sexs.Add(new Field { Value = "women", Name = "Женщина" });
        }

        private static void InitiateDocumentStatuses()
        {
            DocumentStatuses.Add(new Field { Value = "all", Name = "Все документы" });
            DocumentStatuses.Add(new Field { Value = "new", Name = "Новые документы" });
            DocumentStatuses.Add(new Field { Value = "inWork", Name = "Документы в обработке" });
            DocumentStatuses.Add(new Field { Value = "closed", Name = "Завершенные документы" });
        }

        private static void InitiateDocumentTypes()
        {
            DocumentTypes.Add(new Field { Value = "none", Name = "Тип документа" });
            DocumentTypes.Add(new Field { Value = "РВП", Name = "РВП" });
            DocumentTypes.Add(new Field { Value = "ВНЖ", Name = "ВНЖ" });
        }

        private static void InitiateCountrys()
        {
            Countrys.Add(new Field { Value = "none", Name = "Выбор страны" });
            Countrys.Add(new Field { Value = "Беларуское", Name = "Беларусь" });
            Countrys.Add(new Field { Value = "Казахстан", Name = "Казахстан" });
            Countrys.Add(new Field { Value = "Украина", Name = "Украина" });
            Countrys.Add(new Field { Value = "Молдова", Name = "Молдова" });
        }

        public static IEnumerable<SelectListItem> GetCountrys()
        {
            return Countrys.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetDocumentTypes()
        {
            return DocumentTypes.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetDocumentStatuses()
        {
            return DocumentStatuses.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetSexs()
        {
            return Sexs.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetChangedNames()
        {
            return ChangedNames.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetOrderBy()
        {
            return OrderBy.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
        public static IEnumerable<SelectListItem> GetRelativeTypes()
        {
            return RelativeTypes.Select(x => new SelectListItem { Text = x.Name, Value = x.Value }).ToList();
        }
    }
}
