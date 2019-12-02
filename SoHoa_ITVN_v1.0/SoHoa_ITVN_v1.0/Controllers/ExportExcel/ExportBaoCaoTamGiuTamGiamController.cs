using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace CMS.Web.Controllers.Export
{
    public class ExportBaoCaoTamGiuTamGiamController : Controller
    {
    //    // GET: ExportBaoCaoTamGiuTamGiam
    //    // GET: ExportDanhSachCacVuAnToaTraHoSoDieuTra
    //    public FileResult BaoCaoTamGiuTamGiam()
    //    {
    //        //
    //        List<DieuTraBoXung> lstDanhSachVuAnToaTraHoSo = new List<DieuTraBoXung>();
    //        string sWebRootFolder = HostingEnvironment.ApplicationPhysicalPath + "\\FilesUpload";
    //        CreateExport(lstDanhSachVuAnToaTraHoSo,sWebRootFolder);
    //        string fPath = sWebRootFolder + "\\" + "BaoCaoTamGiuTamGiam.xlsx";
    //        FileInfo fi = new FileInfo(fPath);
    //        return File(fPath, System.Net.Mime.MediaTypeNames.Application.Octet, "BaoCaoTamGiuTamGiam" + fi.Extension);
    //    }
    //    public void CreateExport(List<DieuTraBoXung> lst, string sWebRootFolder)
    //    {
    //        //Khởi tạo tham số đầu vào
    //        List<ProperTiesName> lstProperty = new List<ProperTiesName>();
    //        lstProperty.Add(new ProperTiesName { PropsName = "", WidthSize = 40 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "", WidthSize = 20 });
    //        lstProperty.Add(new ProperTiesName { PropsName = "", WidthSize = 20 });
    //        //Tạo đối tượng dùng để Export
    //        ExportCore2<DieuTraBoXung> exh = new ExportCore2<DieuTraBoXung>(5)
    //        {
    //            FileName = "BaoCaoTamGiuTamGiam",
    //            LstObj = lst,
    //            LstProperTies = lstProperty,
    //            SWebRootFolder = sWebRootFolder,
    //            SheetName = "Báo cáo tạm giữ tạm giam"
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
    //            new HeaderLocation(1,3,20,"BÁO CÁO TÌNH HÌNH BẮT GIỮ TẠM GIỮ TẠM GIAM VÀ XỬ LÝ TUẦN"),
    //            new HeaderLocation(2,1,70,"Nội dung"),new HeaderLocation(2,2,10,"STT"),
    //            new HeaderLocation(2,3,25,"TỔNG SỐ")
    //        };
    //        // tạo danh sách các ô bị merge(từ hàng , từ cột, đến hàng,đến cột)
    //        List<MergeTo> lstMerge = new List<MergeTo>()
    //        {
    //            new MergeTo(1,1,1,3)
    //        };
    //        // gán các tham số cho headInput
    //        headInput.ListHeader = lstHeaderLocation;
    //        headInput.ListMergeIndex = lstMerge;
    //        headInput.HeaderHeight = 5; // số hàng mà header chiếm trong excell
    //        return headInput;
    //    }
    }
}