using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class CharacteristicGroupsSemestr2
    {
        public int Id { get; set; }

        [Display(Name = "Введіть назву навчальної дисципліни")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameAcademiDisciplines { get; set; }

        [Display(Name = "Введіть обсяг дисциплін за семестр")]
        [Range(0, 1000, ErrorMessage = "Введіть обсяг дисциплін за семестр (0-1000).")]
        [Required(ErrorMessage = "Введіть обсяг дисциплін за семестр (0-1000).")]
        public double CountDisciplinesSemester { get; set; }

        [Display(Name = "Введіть факультет")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть факультет не більше 10 і не менше 2 символів")]
        [Required(ErrorMessage = "Введіть факультет не більше 10 і не менше 2 символів")]
        public string Faculty { get; set; }

        [Display(Name = "Введіть курс навчання")]
        [Range(0, 4, ErrorMessage = "Введіть курс навчання (0-4).")]
        [Required(ErrorMessage = "Введіть курс навчання (0-4).")]
        public double Curriculum { get; set; }

        [Display(Name = "Введіть к-сть бюджетних академічних груп ")]
        [Range(0, 1000, ErrorMessage = "Введіть к-сть бюджетних академічних груп (0-1000).")]
        [Required(ErrorMessage = "Введіть к-сть бюджетних академічних груп (0-1000).")]
        public double AcademiсGroupsBud { get; set; }

        [Display(Name = "Введіть к-сть бюджетних підгруп для практ. занять")]
        [Range(0, 1000, ErrorMessage = "Введіть к-сть бюджетних підгруп для практ. занять (0-1000).")]
        [Required(ErrorMessage = "Введіть к-сть бюджетних підгруп для практ. занять (0-1000).")]
        public double PracticalLessonBud { get; set; }

        [Display(Name = "Введіть к-сть бюджетних підгруп для лаб. занять")]
        [Range(0, 1000, ErrorMessage = "Введіть к-сть бюджетних підгруп для лаб. занять (0-1000).")]
        [Required(ErrorMessage = "Введіть к-сть бюджетних підгруп для лаб. занять (0-1000).")]
        public double LabLessonBud { get; set; }

        [Display(Name = "Введіть к-сть контрактих академічних груп ")]
        [Range(0, 1000, ErrorMessage = "Введіть к-сть контрактих академічних груп (0-1000).")]
        [Required(ErrorMessage = "Введіть к-сть контрактих академічних груп (0-1000).")]
        public double AcademicGroupsCon { get; set; }

        [Display(Name = "Введіть к-сть контрактих підгруп для практ. занять")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double PracticalLessonCon { get; set; }

        [Display(Name = "Введіть к-сть контрактих підгруп для лаб. занять")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double LabLessonCon { get; set; }

        [Display(Name = "Введіть шифр групи")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Шифр не більше 10 і не менше 2 символів")]
        [Required(ErrorMessage = "Шифр не більше 10 і не менше 2 символів")]
        public string CodeGrup { get; set; }

        [Display(Name = "Введіть к-сть кількість студентів за бюджетом")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStudentsBud { get; set; }

        [Display(Name = "Введіть к-сть кількість студентів за контрактом")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStudentsCon { get; set; }

        [Display(Name = "Введіть к-сть бюджетних потоків")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStreamsBud { get; set; }

        [Display(Name = "Введіть к-сть контрактних потоків")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountStreamsCon { get; set; }

        public string EmailTeacher { get; set; }
    }
}
