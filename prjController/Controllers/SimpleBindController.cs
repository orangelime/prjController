using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjToDo.Controllers
{
    public class SimpleBindController : Controller
    {
        // GET: SimpleBind
        public ActionResult Index()
        {
            return View();
        }
        //���w�U�誺Create�ʧ@��k�ӳB�zPOST�ШD
        [HttpPost]
        //��޼ƹ����ܪ��P�W�������
        public ActionResult Create(string PId, string PName, int Price)
        {
            //�N����ƥ��Ȧs��ViewBag���󤤡A����A������W�e�{
            ViewBag.PId = PId;
            ViewBag.PName = PName;
            ViewBag.Price = Price;
            return View();
        }
    }
}