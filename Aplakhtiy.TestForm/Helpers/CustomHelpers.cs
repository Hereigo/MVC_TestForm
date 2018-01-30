using System;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace Aplakhtiy.TestForm.Helpers
{
	public static class CustomHelpers
	{
		public static MvcHtmlString PhoneEditorFor<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> expression)
		{
			MvcHtmlString editor = EditorExtensions.EditorFor(helper, expression, new { htmlAttributes = new { @class= "form-control" } });

			// Wrap Edit with <div style="display:table-cell">

			TagBuilder inputTableCell = new TagBuilder("div");
			inputTableCell.MergeAttribute("style", "display:table-cell;");
			inputTableCell.InnerHtml = editor.ToString();

			TagBuilder prefixDiv = new TagBuilder("div");
			prefixDiv.MergeAttribute("style", "display:table-cell;width:30px;padding-top:5px;");
			prefixDiv.InnerHtml = "38 0";


			TagBuilder phoneFormControl = new TagBuilder("div");
			phoneFormControl.AddCssClass("form-control");
			phoneFormControl.AddCssClass("phone-number");
			phoneFormControl.MergeAttribute("style", "padding:0 0 0 12px;");

			phoneFormControl.InnerHtml = prefixDiv.ToString() + inputTableCell.ToString();



			//TagBuilder editorDiv = new TagBuilder("div");
			//editorDiv.MergeAttribute("style", "display:table-cell");
			//editorDiv.InnerHtml = editor.ToString();

			StringBuilder html = new StringBuilder();
			//html.Append(prefixDiv.ToString());
			//html.Append(editorDiv.ToString());

			html.Append(phoneFormControl.ToString());

			return MvcHtmlString.Create(html.ToString());
		}
	}
}
/*
<div class="form-group col-xs-6">
<label for="Phone">Мобильный телефон</label>
<div class="form-control phone-number" style="padding:0 0 0 12px;">

	<div style="display:table-cell;width:25px;padding-top:5px;">38&nbsp;0</div>
	
	<div style="display:table-cell">
		<input value="" autocomplete="off" data-val="true" data-val-length="Неверный номер!" data-val-length-max="9" data-val-length-min="9" data-val-phone="Телефон содержит недопустимые символы." data-val-regex="Вы ввели код несуществующего оператора." data-val-regex-pattern="^(39|67|68|96|97|98|50|66|95|99|63|73|91|92|93|94).*" data-val-required="Необходимо указать телефон." id="Phone" maxlength="9" name="Phone" onkeydown="numbersOnly(event)" type="tel">
	</div>

</div>
<span class="field-validation-valid" data-valmsg-for="Phone" data-valmsg-replace="true"></span>
</div>
 * =======================================================
<div class="form-group col-xs-6">
<label for="PhoneNumber">Мобильный телефон</label>
<div class="phone-number form-control" style="padding:0 0 0 12px;">

	<div style="display:table-cell;width:30px;padding-top:5px;">38 0</div>

	<div style="display:table-cell;">
		<input class="form-control text-box single-line" data-val="true" data-val-maxlength="Поле Мобильный телефон должно иметь тип строки или массива с максимальной длиной &quot;9&quot;." data-val-maxlength-max="9" data-val-minlength="Поле Мобильный телефон должно иметь тип строки или массива с минимальной длиной &quot;9&quot;." data-val-minlength-min="9" data-val-regex="Некорректный номер мобильного телефона." data-val-regex-pattern="^(39|50|63|66|67|68|73|91|92|93|94|95|96|97|98|99)[0-9]*" data-val-required="Необходимо указать телефон." id="PhoneNumber" name="PhoneNumber" value="" type="text">
	</div>

	</div>
<span class="field-validation-valid text-danger" data-valmsg-for="PhoneNumber" data-valmsg-replace="true"></span>
</div>
 */
