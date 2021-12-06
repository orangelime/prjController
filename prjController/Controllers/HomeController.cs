using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //計算陣列元素的總和
        public string ShowArray()
        {
            int[] score = new int[] { 78, 99, 20, 100, 66 };
            string show = "";
            int sum = 0;
            foreach(var m in score)
            {
                show += m + ",";
                sum += m;
            }
            show += "<br/>";
            show += "總和：" + sum;
            return show;
        }

        //傳回顯示images下的1.png~8.png的HTML字串
        public string ShowImages()
        {
            string show = "";
            for(int i=1;i<=8;i++)
            {
                show += string.Format
                            ("<img src='../images/{0}.png' widh='150'>  ", i);
            }
            return show;
        }

        //依index參數取得對應圖示與說明
        public string ShowImageIndex(int index)
        {
            //宣告name字串陣列用來當作1.png~8.png的美食名稱
            string[] name = new string[] { "可頌麵包", "生日蛋糕", "冰淇淋", "調酒", "咖啡", "漢堡", "日式拉麵", "燒烤" };
            //指定顯示index編號圖示的HTML字串
            string show = string.Format
                ("<p align='center'><img src='../images/{0}.png'><br>{1}</p>", index, name[index]);
            return show;
        }
    }
}