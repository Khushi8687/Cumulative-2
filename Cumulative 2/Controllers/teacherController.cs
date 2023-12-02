using Cumulative_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cumulative_2.Controllers
{
    public class teacherController : Controller
    {
        // GET: teacher1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            teacherdataController controller = new teacherdataController();
            IEnumerable<Teacher> teachers = controller.Listteachers();
            return View(teachers);

        }
        public ActionResult Show(int id)
        {
            teacherdataController controller = new teacherdataController();
            Teacher NewTeacher = controller.FindTeacher(id);


            return View(NewTeacher);
        }

        //GET : /Author/DeleteConfirm
        public ActionResult DeleteConfirm(int id)
        {
            teacherdataController controller = new teacherdataController();
            Teacher NewTeacher = controller.FindTeacher(id);


            return View(NewTeacher);
        }


     
    }
}