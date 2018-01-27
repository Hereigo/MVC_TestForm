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

		[Display(Name="Прізвище")]
		[Required(ErrorMessage = "Прізвище обов'язково вказувати")]
		public string Surname { get; set; }

		[Display(Name = "Ім'я")]
		[Required(ErrorMessage = "Ім'я обов'язково вказувати")]
		public string Name { get; set; }

		[Display(Name = "По-батькові")]
		[Required(ErrorMessage = "По-батькові обов'язково вказувати")]
		public string Patronymic { get; set; }

		[Display(Name = "Номер телефону")]
		[Required(ErrorMessage = "Номер телефону обов'язково вказувати")]
		public string PhoneNumber { get; set; }

		[Display(Name = "Працює")]
		public bool Employed { get; set; }

		[Display(Name = "Назва організації")]
		public string OrganizationName { get; set; }

		[Display(Name = "Почав працювати")]
		public DateTime? StartOnUtc { get; set; }
	}
}