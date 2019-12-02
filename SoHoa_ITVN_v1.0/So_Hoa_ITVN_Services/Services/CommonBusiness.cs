using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Hoa_ITVN_Services
{
    //public class CommonBusiness : ServiceBase<KhoanLuat>
    //{
    //    public int XacDinhLoaiToiPham(List<int> dsKhoanLuatID, int? boLuat = 2015)
    //    {
    //        int loaiToiPham = LoaiToiPhamConts.CHUA_XEP_LOAI;
    //        bool laTuHinh = DbContext.KhoanLuat.Any(x => dsKhoanLuatID.Contains(x.KhoanLuatID) && x.LaTuHinh == true);
    //        bool laChungThan = DbContext.KhoanLuat.Any(x => dsKhoanLuatID.Contains(x.KhoanLuatID) && x.LaChungThan == true);
    //        if (laTuHinh || laChungThan)
    //        {
    //            loaiToiPham = LoaiToiPhamConts.DAC_BIET_NGHIEM_TRONG;
    //            return loaiToiPham;
    //        }
    //        double? soNamPhatTuMax = DbContext.KhoanLuat.Where(x => dsKhoanLuatID.Contains(x.KhoanLuatID))
    //            .Max(x => x.PhatTuDen);
    //        if (soNamPhatTuMax.HasValue && soNamPhatTuMax <= 3)
    //            loaiToiPham = LoaiToiPhamConts.IT_NGHIEM_TRONG;
    //        else if (soNamPhatTuMax.HasValue && soNamPhatTuMax > 3 && soNamPhatTuMax <= 7)
    //            loaiToiPham = LoaiToiPhamConts.NGHIEM_TRONG;
    //        else if (soNamPhatTuMax.HasValue && soNamPhatTuMax > 7 && soNamPhatTuMax <= 15)
    //            loaiToiPham = LoaiToiPhamConts.RAT_NGHIEM_TRONG;
    //        else if (soNamPhatTuMax.HasValue && soNamPhatTuMax > 15)
    //            loaiToiPham = LoaiToiPhamConts.DAC_BIET_NGHIEM_TRONG;
    //        return loaiToiPham;
    //    }
    //}
}
