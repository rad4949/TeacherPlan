using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class OtherTypesWorkSemestr2
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Вид роботи")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть вид не більше 60 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameOtherTypesWork { get; set; }

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
        public int ColumId { get; set; }
        public string EmailTeacher { get; set; }
    }
}
