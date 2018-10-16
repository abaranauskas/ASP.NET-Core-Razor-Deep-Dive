using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace OrderingApplication.Helpers
{
    public static class CustomHtmlHelpers
    {
        public static IHtmlContent LabeledTextBoxFor<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, string labelText)
        {
            var label = htmlHelper.LabelFor(expression, labelText);
            var textBox = htmlHelper.TextBoxFor(expression, new { @class = "form-control" });

            using (var writer = new StringWriter())
            {
                label.WriteTo(writer, HtmlEncoder.Default);
                textBox.WriteTo(writer, HtmlEncoder.Default);
                return new HtmlString(writer.GetStringBuilder().ToString());
            }

           
        }
    }
}
