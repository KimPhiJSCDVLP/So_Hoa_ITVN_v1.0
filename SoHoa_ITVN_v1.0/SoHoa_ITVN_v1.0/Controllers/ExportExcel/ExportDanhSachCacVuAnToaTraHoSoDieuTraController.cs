using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace CMS.Web.Controllers.Export
{
    public class ExportDanhSachCacVuAnToaTraHoSoDieuTraController : Controller
    {
    //    // GET: ExportDanhSachCacVuAnToaTraHoSoDieuTra
    //    public class DieuTraBuSung
    //    {
    //        public string soNgayQDTraBoSung { get; set; }
    //        public string thoiHanTraDTBS { get; set; }
    //        public string tenBCDauVu { get; set; }
    //        public string soBiCan { get; set; }
    //        public string toiDanh { get; set; }
    //        public int? soLanTra { get; set; }
    //        public string chungCu { get; set; }
    //        public string toTung { get; set; }
    //        public string khoiToMoi { get; set; }
    //        public string tinhTietMoi { get; set; }
    //        public string danhGiaChungCuVaToiDanhKhacNhau { get; set; }
    //        public string vKSRutHoSo { get; set; }
    //        public string khac { get; set; }
    //        public string tomTatNoiDung { get; set; }
    //        public string quanDiemChapNhan { get; set; }
    //        public string quanDiemKhongChapNhan { get; set; }
    //        public string trachNhiemVKS { get; set; }
    //        public string trachNhiemTA { get; set; }
    //        public string kiemSatVien { get; set; }
    //        public string thamPhan { get; set; }
    //        public string ghiChu { get; set; }
    //    }

    //    public FileResult DanhSachCacVuAnToaTraHoSoDieuTra()
    //    {
    //        List<DieuTraBuSung> lstDieuTraBoSung = new List<DieuTraBuSung>();
    //        List<DieuTraBoXung> lstDanhSachVuAnToaTraHoSo = new List<DieuTraBoXung>();
    //        using (ApplicationDbContext db = new ApplicationDbContext())
    //        {
    //            lstDanhSachVuAnToaTraHoSo = db.DieuTraBoXung
    //             .Include(x => x.QuyetDinhHoSo.QuyetDinh)
    //             .Include(x => x.QuyetDinhHoSo.DieuLuat)
    //             .Include(x => x.QuyetDinhHoSo.KhoanLuat)
    //             .Include(x => x.QuyetDinhHoSo.DiemLuat)
    //             .Include(y => y.QuyetDinhHoSo.HoSoAnHinhSu.BiCanHoSo.Select(x => x.BiCan))
    //             .Include(x => x.Nhansu)
    //             .Where(x => x.HinhThuc == 0 && x.QuyetDinhHoSo.QuyetDinh.LoaiQuyetDinhID == LoaiQuyetDinhConst.QD_TRA_HO_SO_DE_YEU_CAU_DIEU_TRA_BO_SUNG) //Quyết định trả hồ sơ bổ sung
    //             .OrderByDescending(x => x.DieuTraBoXungID)
    //           .ToList();
    //        }
    //        DieuTraBuSung dTBS = new DieuTraBuSung();
    //        foreach(DieuTraBoXung dtbs in lstDanhSachVuAnToaTraHoSo)
    //        {
    //            dTBS.soNgayQDTraBoSung = ((DateTime)dtbs.NgayTra).ToString("dd/M/yyyy");
    //            dTBS.thoiHanTraDTBS = dtbs.ThoiHanDTBX.ToString();
    //            if(dtbs.QuyetDinhHoSo != null)
    //            {
    //                if (dtbs.QuyetDinhHoSo.HoSoAnHinhSu != null)
    //                {
    //                    if (dtbs.QuyetDinhHoSo.HoSoAnHinhSu.BiCanHoSo.Count != 0)
    //                    {
    //                        int count = 0;
    //                        foreach (BiCanHoSo biCanHoSo in dtbs.QuyetDinhHoSo.HoSoAnHinhSu.BiCanHoSo)
    //                        {
    //                            if (biCanHoSo.BiCan.LaBiCanDauVu == true)
    //                            {
    //                                dTBS.tenBCDauVu = biCanHoSo.BiCan.HoTen.ToString();
    //                                dTBS.soBiCan = biCanHoSo.BiCan.BiCanID.ToString();
    //                                count = count + 1;
    //                                break;
    //                            }
    //                        }
    //                        if (count == 0)
    //                        {
    //                            dTBS.tenBCDauVu = "";
    //                        }
    //                    }
    //                }
    //            }
    //            dTBS.toiDanh = dtbs.QuyetDinhHoSo.KhoanLuat.NoiDung.ToString();
    //            dTBS.soLanTra = null;
    //            dTBS.chungCu = dtbs.LyDoChungCu;
    //            dTBS.toTung = dtbs.LyDoToTung;
    //            dTBS.khoiToMoi = dtbs.LyDoKhoiToMoi;
    //            dTBS.tinhTietMoi = dtbs.LyDoTinhTietMoi;
    //            dTBS.danhGiaChungCuVaToiDanhKhacNhau = dtbs.LyDoChungCuToiDanhKhacNhau;
    //            dTBS.vKSRutHoSo = "";
    //            dTBS.khac = dtbs.LyDoKhac;
    //            dTBS.tomTatNoiDung = dtbs.TomTatNoiDungTra;
    //            dTBS.quanDiemChapNhan = dtbs.QuanDiemVKS;
    //            dTBS.quanDiemKhongChapNhan = dtbs.QuanDiemVKS;
    //            dTBS.trachNhiemVKS = dtbs.TrachNhiemVKS;
    //            dTBS.trachNhiemTA = dtbs.TrachNhiemVKS;
    //            dTBS.kiemSatVien = dtbs.Nhansu.HoTen;
    //            dTBS.thamPhan = dtbs.TenDieuTraVien;
    //            dTBS.ghiChu = dtbs.GhiChu;
    //            lstDieuTraBoSung.Add(dTBS);
    //            dTBS = new DieuTraBuSung();
    //        }
    //        //
    //        string sWebRootFolder = HostingEnvironment.ApplicationPhysicalPath + "\\FilesUpload";
    //        CreateExport(lstDieuTraBoSung, sWebRootFolder);
    //        string fPath = sWebRootFolder + "\\" + "DanhSachCacVuAnToaTraHoSoDieuTra.xlsx";
    //        FileInfo fi = new FileInfo(fPath);
    //        return File(fPath, System.Net.Mime.MediaTypeNames.Application.Octet, "DanhSachCacVuAnToaTraHoSoDieuTra" + fi.Extension);
    //    }
    //    public void CreateExport(List<DieuTraBuSung> lst, string sWebRootFolder)
    //    {
    //        //Khởi tạo tham số đầu vào
    //        List<ProperTiesName> lstProperty = new List<ProperTiesName>();
    //        lstProperty.Add(new ProperTiesName { PropsName = "", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "soNgayQDTraBoSung", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "thoiHanTraDTBS", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "tenBCDauVu", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "soBiCan", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "toiDanh", WidthSize = 50 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "soLanTra", WidthSize = 50 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "chungCu", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "toTung", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "khoiToMoi", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "tinhTietMoi", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "danhGiaChungCuVaToiDanhKhacNhau", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "vKSRutHoSo", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "khac", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "tomTatNoiDung", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "quanDiemChapNhan", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "quanDiemKhongChapNhan", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "trachNhiemVKS", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "trachNhiemTA", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "kiemSatVien", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "thamPhan", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "ghiChu", WidthSize = 40 });
    //        //Tạo đối tượng dùng để Export
    //        ExportCore2<DieuTraBuSung> exh = new ExportCore2<DieuTraBuSung>(4)
    //        {
    //            FileName = "DanhSachCacVuAnToaTraHoSoDieuTra",
    //            LstObj = lst,
    //            LstProperTies = lstProperty,
    //            SWebRootFolder = sWebRootFolder,
    //            SheetName = "Danh sách vụ án tòa trả hồ sơ"
    //        };
    //        exh.HeaderInput = CreateHeader();
    //        exh.RunExport();
    //        //
    //    }
    //    // Tạo header
    //    public HeaderInputs CreateHeader()
    //    {
    //        HeaderInputs headInput = new HeaderInputs();
    //        // Tạo danh sách header với các đầu vào(row, colum,size,text)
    //        List<HeaderLocation> lstHeaderLocation = new List<HeaderLocation>()
    //        {
    //            new HeaderLocation(1,22,20,"DANH SÁCH CÁC VỤ ÁN TÒA ÁN TRẢ HỒ SƠ ĐIỀU TRA BỔ SUNG"),
    //            new HeaderLocation(2,1,20,"STT"),new HeaderLocation(2,2,20,"Số,ngày QĐ trả BS"),
    //            new HeaderLocation(2,3,10,"Thời hạn trả điều tra bổ sung"),new HeaderLocation(2,4,10,"Tên bị can đầu vụ"),
    //            new HeaderLocation(2,5,25,"Số BC"),new HeaderLocation(2,6,60,"Tội danh"),
    //            new HeaderLocation(2,7,10,"Số lần trả"),new HeaderLocation(2,8,20,"Lý do trả"),
    //            new HeaderLocation(3,8,10,"Chứng cứ"),new HeaderLocation(3,9,10,"Tố tụng"),new HeaderLocation(3,10,20,"Khởi tố mới"),new HeaderLocation(3,11,10,"Lý do khác"),
    //            new HeaderLocation(4,11,20,"Tình tiết mới"),new HeaderLocation(4,12,20,"Đánh giá chứng cứ và tội danh khác nhau"),new HeaderLocation(4,13,10,"VKS rút hồ sơ"),new HeaderLocation(4,14,10,"Khác"),
    //            new HeaderLocation(2,15,10,"Tóm tắt nội dung trả ĐTBS"),new HeaderLocation(2,16,10,"Quan điểm của VKS"),new HeaderLocation(3,16,10,"Chấp nhận"),
    //            new HeaderLocation(3,17,10,"Không chấp nhận"),new HeaderLocation(2,18,10,"Trách nhiệm"),new HeaderLocation(3,18,10,"VKS"),
    //            new HeaderLocation(3,19,20,"TA"),new HeaderLocation(2,20,20,"Kiểm sát viên"),new HeaderLocation(2,21,20,"Thẩm phán"),new HeaderLocation(2,22,20,"Ghi chú"),
    //        };
    //        // tạo danh sách các ô bị merge(từ hàng , từ cột, đến hàng,đến cột)
    //        List<MergeTo> lstMerge = new List<MergeTo>()
    //        {
    //            new MergeTo(1,1,1,22),
    //            new MergeTo(2,8,2,14),
    //            new MergeTo(3,11,3,14),
    //            new MergeTo(2,16,2,17),
    //             new MergeTo(2,18,2,19)
    //        };
    //        // gán các tham số cho headInput
    //        headInput.ListHeader = lstHeaderLocation;
    //        headInput.ListMergeIndex = lstMerge;
    //        headInput.HeaderHeight = 5; // số hàng mà header chiếm trong excell
    //        return headInput;
    //    }
    }
}