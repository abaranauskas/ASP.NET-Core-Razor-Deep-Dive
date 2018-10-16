using Microsoft.AspNetCore.Mvc.Rendering;
using OrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.Services
{
    public class FormDataService : IFormDataService
    {
        public List<SelectListItem> GetLocations()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Northeast", Value = "1" },
                new SelectListItem() { Text = "West", Value = "2" },
                new SelectListItem() { Text = "Downtown", Value = "3" },
                new SelectListItem() { Text = "Township", Value = "4" }
            };
        }

        public List<SelectListItem> GetClientTypes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Small Business" },
                new SelectListItem() { Text = "Individual" },
                new SelectListItem() { Text = "Corporation" }
            };
        }

        public List<SelectListItem> GetStages()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() {Text = "Intake" },
                new SelectListItem() {Text = "Inventory Fulfillment" },
                new SelectListItem() {Text = "Billing" },
                new SelectListItem() {Text = "Prep for Shipping" },
                new SelectListItem() {Text = "Shipped" },
                new SelectListItem() {Text = "Delivery Confirmation" },
                new SelectListItem() {Text = "On Hold" }
            };
        }
    }
}
