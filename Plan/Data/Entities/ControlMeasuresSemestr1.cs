using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class ControlMeasuresSemestr1
    {
        public int Id { get; set; }

        [Display(Name = "Введіть назву навчальної дисципліни")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameAcademiDisciplines { get; set; }

        [Display(Name = "Введіть к-сть екзаменів за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double ExamBudPl { get; set; }

        [Display(Name = "Введіть к-сть екзаменів за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double ExamBudVuc { get; set; }

        [Display(Name = "Введіть к-сть екзаменів за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double ExamConPl { get; set; }

        [Display(Name = "Введіть к-сть екзаменів за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double ExamConVuc { get; set; }


        [Display(Name = "Введіть к-сть заліків за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double TestBudPl { get; set; }

        [Display(Name = "Введіть к-сть заліків за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double TestBudVuc { get; set; }

        [Display(Name = "Введіть к-сть заліків за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double TestConPl { get; set; }

        [Display(Name = "Введіть к-сть заліків за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double TestConVuc { get; set; }


        [Display(Name = "Введіть к-сть контрольних робіт за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double KRBudPl { get; set; }

        [Display(Name = "Введіть к-сть контрольних робіт за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double KRBudVuc { get; set; }

        [Display(Name = "Введіть к-сть контрольних робіт за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double KRConPl { get; set; }

        [Display(Name = "Введіть к-сть контрольних робіт за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double KRConVuc { get; set; }


        [Display(Name = "Введіть к-сть курсових робіт за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursRobBudPl { get; set; }

        [Display(Name = "Введіть к-сть курсових робіт за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursRobBudVuc { get; set; }

        [Display(Name = "Введіть к-сть курсових робіт за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursRobConPl { get; set; }

        [Display(Name = "Введіть к-сть курсових робіт за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursRobConVuc { get; set; }


        [Display(Name = "Введіть к-сть курсових проектів за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursProectBudPl { get; set; }

        [Display(Name = "Введіть к-сть курсових проектів за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursProectBudVuc { get; set; }

        [Display(Name = "Введіть к-сть курсових проектів за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursProectConPl { get; set; }

        [Display(Name = "Введіть к-сть курсових проектів за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CursProectConVuc { get; set; }


        [Display(Name = "Введіть к-сть РГР, РР, ГР за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double RGRBudPl { get; set; }

        [Display(Name = "Введіть к-сть РГР, РР, ГР за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double RGRBudVuc { get; set; }

        [Display(Name = "Введіть к-сть РГР, РР, ГР за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double RGRConPl { get; set; }

        [Display(Name = "Введіть к-сть РГР, РР, ГР за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double RGRConVuc { get; set; }


        [Display(Name = "Введіть к-сть ДКР за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double DKRBudPl { get; set; }

        [Display(Name = "Введіть к-сть ДКР за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double DKRBudVuc { get; set; }

        [Display(Name = "Введіть к-сть ДКР за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double DKRConPl { get; set; }

        [Display(Name = "Введіть к-сть ДКР за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double DKRConVuc { get; set; }


        [Display(Name = "Введіть к-сть рефератів за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double AbstractBudPl { get; set; }

        [Display(Name = "Введіть к-сть рефератів за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double AbstractBudVuc { get; set; }

        [Display(Name = "Введіть к-сть рефератів за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double AbstractConPl { get; set; }

        [Display(Name = "Введіть к-сть рефератів за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double AbstractConVuc { get; set; }


        [Display(Name = "Введіть к-сть консультацій за бюджетом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CosultationBudPl { get; set; }

        [Display(Name = "Введіть к-сть консультацій за бюджетом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CosultationBudVuc { get; set; }

        [Display(Name = "Введіть к-сть консультацій за контрактом пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CosultationConPl { get; set; }

        [Display(Name = "Введіть к-сть консультацій за контрактом вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CosultationConVuc { get; set; }
        public string EmailTeacher { get; set; }

    }
}
