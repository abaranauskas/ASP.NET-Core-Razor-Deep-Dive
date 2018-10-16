using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderingApplication.ViewComponents;

namespace OrderingApplication.Services
{
    public class SurveyService : ISurveyService
    {
        private List<SurveyProduct> products;

        public SurveyService()
        {
            products = new List<SurveyProduct>()
            {
                new SurveyProduct() { Id = 1, Name = "Hoodies", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Banners", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Posters", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "T-Shirts", VoteCount = 2 },
            };
        }

        public List<SurveyProduct> GetSurveyProducts()
        {        

            return products;
        }

        public void IncreaseVoitCount(int productId)
        {
            products.FirstOrDefault(p => p.Id == productId).VoteCount += 1;
        }
    }
}
