using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UploadImageDemo.Controllers
{
    public class CreateRequisitionController : Controller
    {
        //
        // GET: /CreateRequisition/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public void UploadImg()
        {
           string newSRno = "Abf";
           // SRimageURL is configured in web.config file. 
           string strSRimageURL = System.Configuration.ConfigurationManager.AppSettings["SRimageURL"].ToString();
           string SRPath = Path.Combine(strSRimageURL, newSRno);
           var file = Request.Files[0];
           if (file != null && file.ContentLength > 0)
           {
               var fileName = Path.GetFileName(file.FileName);
               var path = Path.Combine(SRPath, fileName);
               file.SaveAs(path);
           }
        }
	}
}