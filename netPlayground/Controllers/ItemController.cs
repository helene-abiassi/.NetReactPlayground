 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netPlayground.Controllers.Models
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase //ControllerBase
    {
        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();

        //}

        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, Title = "The Godfather", ImageId=1, Ranking=0,ItemType=1 },
            new ItemModel{Id =2, Title = "Casablanca", ImageId=2, Ranking=0,ItemType=1 },

        };

        [HttpGet("{itemType:int}")] //This will be equivalent in client to fetch('item/${itemType})
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(2000);
            return items;
        }
    } 
}

