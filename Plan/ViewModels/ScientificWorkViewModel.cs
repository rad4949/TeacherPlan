using Plan.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class ScientificWorkViewModel
    {
        [Display(Name = "Назва. Кількісна характеристика")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        [Required(ErrorMessage = "Введіть назву не більше 50 і не менше 2 символів ")]
        public string NameScientificWork { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Термін виконання")]
        public DateTime DateSuccess { get; set; }

        public bool Correct { get; set; }
    }

    public class ListScientificWorkViewModel
    {
        public List<ScientificWork> scientificWorks { get; set; }
        public AllUserViewModel userModel { get; set; }
    }
}