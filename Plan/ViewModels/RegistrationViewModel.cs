using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plan.ViewModels
{
    public class RegistrationViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ім'я")]
        [StringLength(15)]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Name { get; set; }

        [Display(Name = "Прізвище")]
        [StringLength(25)]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string LastName { get; set; }

        [Display(Name = "Пошта")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        [EmailAddress(ErrorMessage = "Не коректна пошта")]
        public string Email { get; set; }
        //
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^[+]380\d{9}$", ErrorMessage="Некоректний номер телефону")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Не коректний пароль")]
        public string Password { get; set; }
    }
}
