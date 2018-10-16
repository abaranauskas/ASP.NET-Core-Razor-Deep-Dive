using Microsoft.AspNetCore.Mvc.Rendering;
using OrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Services
{
    public interface IFormDataService
    {
        List<SelectListItem> GetLocations();
        List<SelectListItem> GetClientTypes();
        List<SelectListItem> GetStages();
    }
}
