using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Xml.Serialization;

namespace Aplakhtiy.TestForm.Helpers
{
	public static class CustomHelpers
	{
		public static MvcHtmlString PhoneEditorFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression)
		{
			MvcHtmlString label = LabelExtensions.LabelFor(helper, expression, new { @class = "control-label col-md-2" });
			MvcHtmlString editor = EditorExtensions.EditorFor(helper, expression, new { htmlAttributes = new { @class = "form-control" } });
			MvcHtmlString validation = ValidationExtensions.ValidationMessageFor(helper, expression, null, new { @class = "text-danger" });

			// Build the input elements
			TagBuilder editorDiv = new TagBuilder("div");
			editorDiv.AddCssClass("form-control text-box single-line");
			editorDiv.InnerHtml = editor.ToString();

			// Build the validation message elements
			TagBuilder validationSpan = new TagBuilder("span");
			validationSpan.AddCssClass("col-md-10");
			validationSpan.InnerHtml = validation.ToString();

			TagBuilder validationDiv = new TagBuilder("div");
			validationDiv.AddCssClass("field-validation-valid text-danger");
			validationDiv.InnerHtml = validationSpan.ToString();
			
			// Combine all elements
			StringBuilder html = new StringBuilder();
			html.Append(label.ToString());
			html.Append(editorDiv.ToString());
			html.Append(validationDiv.ToString());
			
			// Build the outer div
			TagBuilder outerDiv = new TagBuilder("div");
			outerDiv.AddCssClass("form-group");
			outerDiv.InnerHtml = html.ToString();

			return MvcHtmlString.Create(outerDiv.ToString());
		}
	}
}