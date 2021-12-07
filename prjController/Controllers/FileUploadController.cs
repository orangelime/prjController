using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//檔案傳輸
using System.IO;

namespace prjController.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            //上傳圖片
            string fileName = "";
            //先判斷有檔案
            if (photo != null)
            {
                //檔案的大小需大於0
                if (photo.ContentLength > 0)
                {
                    //取得圖檔名稱，並將檔案儲存到專案的Photos資料夾
                    fileName = Path.GetFileName(photo.FileName);
                    var path = Path.Combine
                        (Server.MapPath("~/Photos"), fileName);
                    photo.SaveAs(path);
                }
            }
            return RedirectToAction("ShowPhotos");
        }

        //顯示Photos資料夾下的所有圖片
        public string ShowPhotos()
        {
            string show = "";
            //建立可操作Photos資料夾的dir物件
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));
            //取得dir物件下的所有檔案(即photots資料夾下)並放入finfo檔案資訊陣列
            FileInfo[] fInfo = dir.GetFiles();
            int n = 0;
            //逐一將fInfo檔案資訊陣列內的所有圖檔指定給show變數
            foreach(FileInfo result in fInfo)
            {
                n++;
                show += "<a href='../Photos/" + result.Name + "'Target='_blank'><img src='../Photos/" + result.Name + "'width='90' height='60' border='0'></a>   ";
                
                //一列顯示四張圖
                if(n % 4 == 0)
                {
                    show += "<p>";
                }
            }
            //show變數再加上'返回' Create 動作方法的連結
            show += "<p><a href='Create'>返回</a></p>";
            return show;
        }
    }
}