using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Helpers
{
    public class ProgressBarTagHelper:TagHelper
    {
        public string Stage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int progress = 10;
            switch (Stage)
            {
                case "Intake":
                    progress = 25;
                    break;
                case "Billing":
                    progress = 50;
                    break;
                case "Shipped":
                    progress = 75;
                    break;
            }

            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", "progress-bar progress-bar-success progress-bar-striped");
            output.Attributes.SetAttribute("style", "width: " + progress + "%");
        }
    }
}
