using course1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course1.Controllers
{
    public class OreController : Controller
    {
        public IActionResult Index()
        {
            List<OresModel> oreList = new List<OresModel>();
            if (oreList.Count == 0)
            {
                oreList.Add(new OresModel { ID = 1, Name = "Iron", Description = "Iron ore from Mexico", Price = 158.99m, Date = new DateTime(2015, 12, 31)});
                oreList.Add(new OresModel { ID = 2, Name = "cobalt", Description = "Cobalt from China", Price = 227.00m, Date = new DateTime(2015, 9, 18) });
                oreList.Add(new OresModel { ID = 3, Name = "Nickel", Description = "Nickel from USA", Price = 78.40m, Date = new DateTime(2015, 11, 22) });
                oreList.Add(new OresModel { ID = 4, Name = "Platinum", Description = "Platinum from Japan", Price = 370.00m, Date = new DateTime(2015, 10, 01) });
            }

            return View(oreList);
        }
    }
}
