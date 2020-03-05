using promise的用法.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace promise的用法.Controllers
{
    public class StudentController : Controller
    {
        // GET: API
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            List<StudentInfo> list = new List<StudentInfo>() {

               new StudentInfo{  Name="马良"},
               new StudentInfo{ Name="马青"}
           };

            var data = new
            {
                responseCode = "000001",

                responseData = list
            };

            return new JsonResult() { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult AWT()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult ThenThen() {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult All()
        {
            return View();
        }

        public ActionResult Then()
        {
            return View();
        }
    }
}