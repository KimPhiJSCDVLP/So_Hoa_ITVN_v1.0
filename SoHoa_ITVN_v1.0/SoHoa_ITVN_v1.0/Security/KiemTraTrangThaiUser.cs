using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITVN.Security
{
    public class KiemTraTrangThaiUser
    {
        private const int soLanNhapSai = 5;
        private const int thoiGianKhoaNhapSai = 15;
        private const int thoiGianKhoaNhapSaiToiDa = 240;

        //public static string Check(int? UserID, bool password = false)
        //{
        //    ApplicationDbContext db = new ApplicationDbContext();
        //    if (UserID == null || UserID == 0)
        //        return null;

        //    var TrangThai = db.TrangThaiUser.Where(x => x.UserID == UserID).FirstOrDefault();
        //    if (TrangThai == null)
        //        return null;

        //    var ThoiGianNhapSai = new DateTime();
        //    if (password)
        //    {
        //        TrangThai.SoLanDangNhapSai = 0;
        //        TrangThai.LaDangNhapSai = false;
        //    }
        //    else
        //    {
        //        if (TrangThai.SoLanDangNhapSai == null)
        //            TrangThai.SoLanDangNhapSai = 0;
        //        TrangThai.SoLanDangNhapSai++;

        //        if ((TrangThai.SoLanDangNhapSai / soLanNhapSai) * thoiGianKhoaNhapSai == thoiGianKhoaNhapSaiToiDa)
        //            return "Tài khoản của bạn đã bị khóa do nhập quá số lần quy định. Vui lòng liên hệ bộ phận kỹ thuật để mở khóa!!!";
        //        if (TrangThai.SoLanDangNhapSai / soLanNhapSai == 0)
        //        {
        //            TrangThai.LaDangNhapSai = true;
        //            TrangThai.NgayViPham = DateTime.Now;
        //        }
        //        ThoiGianNhapSai = TrangThai.NgayViPham.Value.AddMinutes((Double)((TrangThai.SoLanDangNhapSai / soLanNhapSai) * thoiGianKhoaNhapSai));
        //    }
        //    if (TrangThai.LaKhoaTamThoi != null && TrangThai.LaKhoaTamThoi.Value)
        //    {
        //        if (TrangThai.NgayKhoaTamThoi != null && TrangThai.ThoiGianKhoaTamThoi != null && TrangThai.NgayKhoaTamThoi.Value.AddDays(TrangThai.ThoiGianKhoaTamThoi.Value) < DateTime.Now)
        //            TrangThai.LaKhoaTamThoi = false;
        //        else
        //        {
        //            return "Tài khoản đã bị khóa đến ngày " + TrangThai.NgayKhoaTamThoi.Value.AddDays(TrangThai.ThoiGianKhoaTamThoi.Value).ToString("dd/MM/yyyy") + "!!!";
        //        }
        //    }
        //    db.SaveChanges();
        //    if (TrangThai.LaKhoaVinhVien != null && TrangThai.LaKhoaVinhVien.Value)
        //        return "Tài khoản đã bị khóa vĩnh viễn!!!";
        //    if (TrangThai.LaDangNhapSai != null && TrangThai.LaDangNhapSai.Value)
        //    {
        //        if (ThoiGianNhapSai > DateTime.Now)
        //            return "Tài khoản đã nhập sai quá số lần quy định. Nhập lại sau " + ThoiGianNhapSai.ToString("dd/MM/yyyy hh:ss");
        //        else
        //            return null;
        //    }
        //    if (TrangThai.LaChuaKhoiDong != null && TrangThai.LaChuaKhoiDong.Value)
        //        return "Tài khoản của bạn chưa được xác nhận!!!";

        //    return null;
        //}
    }
}