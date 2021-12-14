using Microsoft.AspNetCore.Mvc.ModelBinding;
using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class OtherTypesWorkViewModel
    {
        public int Id { get; set; }

        public int ColumId { get; set; }

        [Display(Name = "Фак-т (інститут)")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть факультет (інститут) не більше 60 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть факультет не більше 50 і не менше 2 символів ")]
        public string Faculty { get; set; }

        [Display(Name = "Курс")]
        [Range(0, 4, ErrorMessage = "Введіть (0-4).")]
        [Required(ErrorMessage = "Введіть (0-4).")]
        public double Course { get; set; }

        [Display(Name = "Шифр групи")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть причину не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть шифр не більше 50 і не менше 2 символів ")]
        public string CodeGrup { get; set; }

        [Display(Name = "К-сть студентів бюджет")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStudentsBud { get; set; }

        [Display(Name = "К-сть студентів контракт")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStudentsCon { get; set; }

        [Display(Name = "Всього годин бюджет пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double HoursBudPl { get; set; }

        [Display(Name = "Всього годин бюджет вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double HoursBudVuc { get; set; }

        [Display(Name = "Всього годин контракт пл")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double HoursConPl { get; set; }

        [Display(Name = "Всього годин контракт вик")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double HoursConVuc { get; set; }
    }

    public class ListOtherTypesWorkViewModel
    {
        public List<OtherTypesWork> otherTypesWorks { get; set; }
        public AllUserViewModel userModel { get; set; }
    }

    public class ListOtherTypesWorkSemestr2ViewModel
    {
        public List<OtherTypesWorkSemestr2> otherTypesWorks { get; set; }
        public AllUserViewModel userModel { get; set; }
    }
}
