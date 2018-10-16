using Microsoft.AspNetCore.Mvc;
using OrderingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingApplication.ViewComponents
{
    public class SurveyWidget : ViewComponent
    {
        private ISurveyService _surveyService;

        public SurveyWidget(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var products = _surveyService.GetSurveyProducts();

            if (productId > 0)
            {
                products.FirstOrDefault(x => x.Id == productId).VoteCount += 1;
                return View("Results", products);
            }

            return View(products);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}
