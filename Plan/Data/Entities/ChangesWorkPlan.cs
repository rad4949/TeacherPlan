using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.Data.Entities
{
    public class ChangesWorkPlan
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Вид роботи")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть вид не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть вид не більше 50 і не менше 2 символів ")]
        public string NameChangesWorkPlan { get; set; }

        [Display(Name = "Зміна у навант. (в годинах)")]
        [Range(0, 1000, ErrorMessage = "Введіть (0-1000).")]
        [Required(ErrorMessage = "Введіть (0-1000).")]
        public double CountReason { get; set; }

        [Display(Name = "Причина зміни")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть причину не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть причину не більше 50 і не менше 2 символів ")]
        public string ReasonChanges { get; set; }
        public string EmailTeacher { get; set; }
    }
}
