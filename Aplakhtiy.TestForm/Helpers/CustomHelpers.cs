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
            MvcHtmlString editor = EditorExtensions.EditorFor(helper, expression,
                new { htmlAttributes = new { @class = "form-control" } });

            TagBuilder inputTableCell = new TagBuilder("div");
            inputTableCell.MergeAttribute("style", "display:table-cell;");
            inputTableCell.MergeAttribute("onkeydown", "numbersOnly(event)");
            inputTableCell.InnerHtml = editor.ToString()
                .Replace("class=\"form-control text-box single-line\"", "style=\"border:0;\"");

            TagBuilder prefixDiv = new TagBuilder("div");
            prefixDiv.MergeAttribute("style", "display:table-cell;width:28px;padding-top:5px;");
            prefixDiv.InnerHtml = "38 0";

            TagBuilder phoneFormControl = new TagBuilder("div");
            phoneFormControl.AddCssClass("form-control text-box single-line");
            phoneFormControl.MergeAttribute("style", "padding:0 0 0 12px;max-width: 280px;");
            phoneFormControl.InnerHtml = prefixDiv.ToString() + inputTableCell.ToString();

            StringBuilder html = new StringBuilder();
            html.Append(phoneFormControl.ToString());

            return MvcHtmlString.Create(html.ToString());
        }
    }
}