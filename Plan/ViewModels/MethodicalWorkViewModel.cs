using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class MethodicalWorkViewModel
    {
        [Display(Name = "Назва. Кількісна характеристика")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameMethodicalWork { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Термін виконання")]
        public DateTime DateSuccess { get; set; }

        public bool Correct { get; set; }
    }

    public class ListMethodicalWorkViewModel
    {
        public List<MethodicalWork> methodicalWorks { get; set; }
        public AllUserViewModel userModel { get; set; }
    }
}
