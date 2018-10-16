using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Helpers
{
    [HtmlTargetElement("span", Attributes ="last-updated")]
    public class LastUpdatedTagHelper: TagHelper
    {
        public DateTime LastUpdated { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (LastUpdated < DateTime.Now.AddDays(-3))
            {
                output.Attributes.SetAttribute("class", "text-danger bold pull-right");
            }
        }
    }
}
