using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderingApplication.ViewComponents;

namespace OrderingApplication.Services
{
    public class InventoryService : IInventoryService
    {
        private List<InventoryItem> _inventory;

        public InventoryService()
        {
            _inventory = new List<InventoryItem>()
            {
                new InventoryItem() {  Name = "Banner", Count = 8 },
                new InventoryItem() {  Name = "Markers", Count = 3 },
                new InventoryItem() {  Name = "Jacket", Count = 4 },
                new InventoryItem() {  Name = "Hoodie", Count = 12 },
                new InventoryItem() {  Name = "Poster", Count = 6 },
                new InventoryItem() {  Name = "Pens", Count = 16 }

            };
        }

        public List<InventoryItem> GetInventorylevel(int threshold)
        {
            return _inventory.Where(i => i.Count <= threshold).ToList();
        }
    }
}
