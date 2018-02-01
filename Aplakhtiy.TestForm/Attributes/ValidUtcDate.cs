using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Aplakhtiy.TestForm.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class ValidUtcDate : ValidationAttribute, IClientValidatable // enable client validation
	{
		public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
		{
			ModelClientValidationRule clientValidation = new ModelClientValidationRule
			{
				ErrorMessage = "Birth Date can not be greater than current date",
				ValidationType = "validutcdate"
			};
			return new[] { clientValidation };
		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null || DateTime.TryParse(value.ToString(), out DateTime parsedDate))
			{
				return ValidationResult.Success;
			}
			else
			{
				return new ValidationResult("Введите корректную дату.");
			}
		}
	}
}