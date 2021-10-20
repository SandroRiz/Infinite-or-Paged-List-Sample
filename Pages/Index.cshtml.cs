using InfiniteList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InfiniteList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<Tour> Tours { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Tours = GetData();
        }

        private IEnumerable<Tour> GetData()
        {
            List<Tour> list = new List<Tour>();
            for (int i = 1; i <= 100; i++)
            {
                list.Add(new Tour { idTour = i , 
                                        TourDate = DateTime.Now.AddDays(i).Date,
                                        TourTitle = "MyTour #" +i.ToString()});
            }
            return list;
        }
    }
}