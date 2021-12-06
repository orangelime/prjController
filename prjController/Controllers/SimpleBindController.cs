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
        //指定下方的Create動作方法來處理POST請求
        [HttpPost]
        //虛引數對應至表單同名的欄位資料
        public ActionResult Create(string PId, string PName, int Price)
        {
            //將表單資料先暫存至ViewBag物件中，之後再到網頁上呈現
            ViewBag.PId = PId;
            ViewBag.PName = PName;
            ViewBag.Price = Price;
            return View();
        }
    }
}