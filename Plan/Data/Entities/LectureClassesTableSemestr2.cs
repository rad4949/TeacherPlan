using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class LectureClassesTableSemestr2
    {
        public int Id { get; set; }

        [Display(Name = "Введіть назву навчальної дисципліни")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameAcademiDisciplines { get; set; }

        [Display(Name = "Введіть к-сть лекцій за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LectureBudPl { get; set; }

        [Display(Name = "Введіть к-сть лекцій за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LectureBudVuc { get; set; }

        [Display(Name = "Введіть к-сть лекцій за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LectureConPl { get; set; }

        [Display(Name = "Введіть к-сть лекцій за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LectureConVuc { get; set; }

        [Display(Name = "Введіть к-сть практичних занять за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int PractBudPl { get; set; }

        [Display(Name = "Введіть к-сть практичних занять за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int PractBudVuc { get; set; }

        [Display(Name = "Введіть к-сть практичних занять за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int PractConPl { get; set; }

        [Display(Name = "Введіть к-сть практичних занять за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int PractConVuc { get; set; }

        [Display(Name = "Введіть к-сть лабораторних занять за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LabBudPl { get; set; }

        [Display(Name = "Введіть к-сть лабораторних занять за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LabBudVuc { get; set; }

        [Display(Name = "Введіть к-сть лабораторних занять за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LabConPl { get; set; }

        [Display(Name = "Введіть к-сть лабораторних занять за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int LabConVuc { get; set; }

        [Display(Name = "Введіть к-сть індивідуальних занять за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int IndBudPl { get; set; }

        [Display(Name = "Введіть к-сть індивідуальних занять за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int IndBudVuc { get; set; }

        [Display(Name = "Введіть к-сть індивідуальних занять за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int IndConPl { get; set; }

        [Display(Name = "Введіть к-сть індивідуальних занять за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public int IndConVuc { get; set; }

        public string EmailTeacher { get; set; }
    }
}
