using Palindrome.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Palindrome.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //This should be an endpoint in a web api
        [HttpGet]
        public JsonResult IsPalindrome(IsPalindromeInputModel model)
        {
            var result = false;

            if (ModelState.IsValid)
                result = IsPalindrome(model.Number);

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        //This should be implemented in a service
        private bool IsPalindrome(int number)
        {
            var result = true;

            number = Math.Abs(number);

            var numberStr = number.ToString();

            if (numberStr.Length == 1)
                return result;

            for (int i = 0; i < numberStr.Length / 2; i++)
            {
                if (!numberStr[i].Equals(numberStr[numberStr.Length - 1 - i]))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}