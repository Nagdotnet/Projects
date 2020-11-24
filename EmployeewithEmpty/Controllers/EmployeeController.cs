using EmployeewithEmpty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeewithEmpty.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee empObj = new Employee();
          List<tbl_Employee> listObj= empObj.getEmployee();
            return View(listObj);
        }

        public JsonResult getjsonData()
        {
            Employee empObj = new Employee();
            List<tbl_Employee> listObj = empObj.getEmployee();
            return Json(listObj,JsonRequestBehavior.AllowGet);
        }
    }
}