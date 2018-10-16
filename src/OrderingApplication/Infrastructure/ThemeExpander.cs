using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Infrastructure
{
    public class ThemeExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            string theme = "Alternate";

            return new List<string>()
            {
                "/Themes/" + theme + "/{1}/{0}.cshtml",
                "/Themes/" + theme + "/Shared/{0}.cshtml",
                "/Themes/Default/{1}/{0}.cshtml",
                "/Themes/Default/Shared/{0}.cshtml"
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            // throw new NotImplementedException();
        }
    }
}
