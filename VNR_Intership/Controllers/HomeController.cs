using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VNR_Intership.EFData;
using VNR_Intership.Models;

namespace VNR_Intership.Controllers
{
    public class HomeController : Controller
    {
        VNR_InternShipEntities db = new VNR_InternShipEntities();
        public ActionResult Index(int? id)
        {
            var response = new KhoaHocModel();
            response.KhoaHocs = db.KhoaHocs.ToList();
            response.MonHocs = db.MonHocs.Where(x => x.KhoaHocID == id).ToList();
            var khoahoc = db.KhoaHocs.Where(x => x.ID == id).FirstOrDefault();
            if (khoahoc != null)
            {
                response.Tenkhoahoc = "Khóa học: " + khoahoc.TenKhoaHoc;
            }
            return View(response);
        }
    }
}