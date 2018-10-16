using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.ViewComponents
{
    public class InventoryWidget : ViewComponent
    {
        private IInventoryService _inventoryService;

        public InventoryWidget(IInventoryService inventory)
        {
            _inventoryService = inventory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            var inventory = _inventoryService.GetInventorylevel(threshold);

            return View("Default", inventory);
        }
    }

    public class InventoryItem
    {
        public InventoryItem()
        {

        }

        public string Name { get; set; }
        public int Count { get; set; }
    }
}
