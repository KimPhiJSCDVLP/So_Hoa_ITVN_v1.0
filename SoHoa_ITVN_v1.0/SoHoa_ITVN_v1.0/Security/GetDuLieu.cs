using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITVN.Security
{
    public class GetDuLieu
    {
        //public static List<DuLieu> GetById(int UserId)
        //{
        //    if (UserId <= 0)
        //        return null;

        //    var lstDuLieu = new List<DuLieu>();
        //    using (ApplicationDbContext db = new ApplicationDbContext())
        //    {
        //        var lstNhomQuyenUser = db.NhomQuyenUser.Where(x => x.UserID == UserId).ToList();
        //        var lstNhomDuLieu = new List<NhomDuLieu>();

        //        foreach (NhomQuyenUser nhomquyenuser in lstNhomQuyenUser)
        //        {
        //            if (nhomquyenuser.NhomQuyenID != 0)
        //                lstNhomDuLieu.AddRange(nhomquyenuser.NhomQuyen.NhomDuLieu);
        //        }
        //        lstNhomDuLieu.ForEach(x =>
        //        {
        //            if (x.HeThong != null)
        //            {
        //                foreach (BangHeThong banghethong in x.HeThong.BangHeThong)
        //                {
        //                    foreach (TruongDuLieu truongdulieu in banghethong.BangDuLieu.TruongDuLieu)
        //                    {
        //                        lstDuLieu.AddRange(truongdulieu.DuLieu);
        //                    }
        //                }
        //            }
        //            if (x.BangDuLieu != null)
        //            {
        //                foreach (TruongDuLieu truongdulieu in x.BangDuLieu.TruongDuLieu)
        //                {
        //                    lstDuLieu.AddRange(truongdulieu.DuLieu);
        //                }
        //            }

        //            if (x.TruongDuLieu != null)
        //            {
        //                lstDuLieu.AddRange(x.TruongDuLieu.DuLieu);
        //            }

        //            if (x.DuLieu != null)
        //            {
        //                lstDuLieu.Add(x.DuLieu);
        //            }
        //        });
        //    }

        //    return lstDuLieu;
        //}
    }
}