//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web.Http;
//using System.Web;
//using System.Net.Http;
//using System.Threading;
//using System.Net;
//using System.Data.Entity;
//using System.Threading.Tasks;
//using System.Web.Http.Filters;
//using System.Web.Http.Controllers;
//using System.Security.Claims;
//using System.Web.Mvc;

//namespace HVITCore.Controllers
//{
//    public class BaseController : Controller
//    {
//        protected Nhansu GetNhanSu()
//        {
//            Nhansu nhansu = null;
//            using (ApplicationDbContext db = new ApplicationDbContext())
//            {
//                if (this.User != null)
//                {
//                    nhansu = db.Nhansu
//                        .Include(x => x.Users)
//                        .Include(x => x.PhongBan)
//                        .Include(x => x.PhongBan.DonVi)
//                        .FirstOrDefault(x => x.Users.UserName.Equals(this.User.Identity.Name));
//                    if (nhansu.Users.DonViDangGiaLapID != null)
//                    {
//                        DonVi donVi = db.DonVi.FirstOrDefault(x => x.DonViID == nhansu.Users.DonViDangGiaLapID);
//                        nhansu.PhongBan.DonVi = donVi;
//                        nhansu.PhongBan.DonViID = (int)nhansu.Users.DonViDangGiaLapID;
//                    }
//                }
//            }
//            return nhansu;
//        }
//    }
//}