using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aplakhtiy.TestForm.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Поле \"Фамилия\" обязательно для заполнения.")]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле \"Имя\" обязательно для заполнения.")]
        public string Name { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Поле \"Отчество\" обязательно для заполнения.")]
        public string Patronymic { get; set; }

        [Display(Name = "Мобильный телефон")]
        [Required(ErrorMessage = "Необходимо указать телефон.")]
		[MinLength(9)]
		[MaxLength(9)]
        [RegularExpression("^(39|50|63|66|67|68|73|91|92|93|94|95|96|97|98|99)[0-9]*",
            ErrorMessage = "Некорректный номер мобильного телефона.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Трудоустроен")]
        public bool Employed { get; set; }

        [Display(Name = "Организация")]
        public string OrganizationName { get; set; }

        [Display(Name = "Работает с")]
        [DataType(DataType.Date)]
        public DateTime? StartOnUtc { get; set; }
    }
}