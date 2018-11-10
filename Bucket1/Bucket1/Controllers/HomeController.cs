using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Bucket1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bucket1.Controllers
{
    public class HomeController : Controller
    {

        public SortModel[] models = new SortModel[]
            {

                new SortModel
                {
                   Input = "4"
                },
                new SortModel
                {
                   Input = "61"
                },
                new SortModel
                {
                   Input = "1"
                },
                new SortModel
                {
                   Input = "16"
                }
            };

        public static List<SortModel> SortModel { get; }

        // GET: /<controller>/
        protected static IActionResult Get(HomeController instance, string stg)
        {
            Contract.Ensures(Contract.Result<IActionResult>() != null);
            for (int i = 0; i < stg.Split(',').Select(int.Parse).ToArray().Length; i++)
            {
                int i;
                for (int j = 0; j < stg.Split(',').Select(int.Parse).ToArray().Length; j++)
                {
                    if (stg.Split(',').Select(int.Parse).ToArray()[i] < stg.Split(',').Select(int.Parse).ToArray()[j])
                    {
                        int temp = stg.Split(',').Select(int.Parse).ToArray()[i];
                        stg.Split(',').Select(int.Parse).ToArray()[i] = stg.Split(',').Select(int.Parse).ToArray()[j];
                        stg.Split(',').Select(int.Parse).ToArray()[j] = temp;
                    }
                }
                var str = "";
                for (i = 0; i < stg.Split(',').Select(int.Parse).ToArray().Length; i++)
                {
                    string a = string.Format("{0},", stg.Split(',').Select(int.Parse).ToArray());
                    str += a;
                }
                return (str);

            }
        }
    }
}
