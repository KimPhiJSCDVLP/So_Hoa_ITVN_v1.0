
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITVN.Security
{

    public class Menu
    {
        public string title { get; set; }
        public string group { get; set; }
        public string component { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public string group { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string href { get; set; }
        public string link { get; set; }
    }

    //public class GetChucNang
    //{
    //    public static List<ChucNang> GetById(int UserId)
    //    {
    //        if (UserId <= 0)
    //            return null;

    //        List<ChucNang> lstChucNang = new List<ChucNang>();
    //        List<NhomChucNang> lstNhomChucNang = new List<NhomChucNang>();
    //        using (ApplicationDbContext db = new ApplicationDbContext())
    //        {
    //            db.Configuration.LazyLoadingEnabled = false;
    //            var Nhomquyenuser = db.NhomQuyenUser
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.ChucNang.ChucNangApi.Select(o => o.Api)))
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.LopDieuKhien.ChucNang.Select(o => o.ChucNangApi.Select(z => z.Api))))
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.HeThong.LopDieuKhien.Select(o => o.ChucNang.Select(k => k.ChucNangApi.Select(z => z.Api)))))
    //                .Where(x => x.UserID == UserId).ToList();
    //            if (Nhomquyenuser == null)
    //                return lstChucNang;

    //            foreach (NhomQuyenUser nhomquyenusers in Nhomquyenuser)
    //            {
    //                if (nhomquyenusers.NhomQuyenID != null)
    //                    lstNhomChucNang.AddRange(nhomquyenusers.NhomQuyen.NhomChucNang);
    //            }

    //            foreach (NhomChucNang nhomchucnang in lstNhomChucNang)
    //            {
    //                if (nhomchucnang.HeThongID != null && nhomchucnang.HeThongID != 0)
    //                {
    //                    foreach (LopDieuKhien lopdieukhien in nhomchucnang.HeThong.LopDieuKhien)
    //                    {
    //                        lstChucNang.AddRange(lopdieukhien.ChucNang);
    //                    }
    //                }

    //                if (nhomchucnang.LopDieuKhienID != null && nhomchucnang.LopDieuKhienID != 0)
    //                {
    //                    lstChucNang.AddRange(nhomchucnang.LopDieuKhien.ChucNang);
    //                }

    //                if (nhomchucnang.ChucNangID != null && nhomchucnang.ChucNangID != 0)
    //                {
    //                    lstChucNang.Add(nhomchucnang.ChucNang);
    //                }
    //            }
    //        }

    //        return lstChucNang;
    //    }

    //    public static List<Menu> GetMenu(int UserID)
    //    {
    //        if (UserID == 0)
    //            return null;
            
    //        List<Menu> menus = new List<Menu>();
    //        List<NhomChucNang> lstNhomChucNang = new List<NhomChucNang>();
    //        Menu moRong = new Menu
    //        {
    //            title = "Mở rộng",
    //            component = "widgets",
    //            group = "widgets",
    //            icon = "list",
    //            link = "#",
    //            items = new List<Item>()
    //        };
    //        using (ApplicationDbContext db = new ApplicationDbContext())
    //        {
    //            var Nhomquyenuser = db.NhomQuyenUser
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.ChucNang.LopDieuKhien))
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.LopDieuKhien.ChucNang))
    //                .Include(x => x.NhomQuyen.NhomChucNang.Select(y => y.HeThong.LopDieuKhien.Select(o => o.ChucNang)))
    //                .Where(x => x.UserID == UserID).ToList();
    //            if (Nhomquyenuser == null)
    //                return null;

    //            foreach (NhomQuyenUser nhomquyenusers in Nhomquyenuser)
    //            {
    //                if (nhomquyenusers.NhomQuyenID != null)
    //                    lstNhomChucNang.AddRange(nhomquyenusers.NhomQuyen.NhomChucNang);
    //            }

    //            foreach (NhomChucNang nhomchucnang in lstNhomChucNang)
    //            {
    //                if (nhomchucnang.HeThongID != null && nhomchucnang.HeThongID != 0)
    //                {
    //                    foreach (LopDieuKhien ldk in nhomchucnang.HeThong.LopDieuKhien)
    //                    {
    //                        if (ldk.LopDieuKhienID != 2)
    //                        {
    //                            var tmp = new Menu
    //                            {
    //                                title = ldk.TenLopDieuKhien,
    //                                component = "widgets",
    //                                group = "widgets",
    //                                icon = ldk.Icon,
    //                                link = "#",
    //                                items = new List<Item>()
    //                            };

    //                            foreach (ChucNang cn in ldk.ChucNang)
    //                            {
    //                                if (cn.LaMenu)
    //                                {
    //                                    if (menus.Where(x => x.title == ldk.TenLopDieuKhien && x.items.Where(y => y.title == cn.TenHienThi).Count() > 0).Count() == 0)
    //                                        tmp.items.Add(new Item
    //                                        {
    //                                            group = "apps",
    //                                            name = cn.TenChucNang,
    //                                            title = cn.TenHienThi,
    //                                            href = cn.Link,
    //                                            link = cn.LinkRouter,
    //                                            icon = cn.Icon
    //                                        });
    //                                }
    //                            }

    //                            menus.Add(tmp);
    //                        }
    //                    }
    //                }

    //                if (nhomchucnang.LopDieuKhienID != null && nhomchucnang.LopDieuKhienID != 0)
    //                {
    //                    var ldk = nhomchucnang.LopDieuKhien;
    //                    if(ldk.LopDieuKhienID != 2)
    //                    {
    //                        var tmp = new Menu
    //                        {
    //                            title = ldk.TenLopDieuKhien,
    //                            component = "widgets",
    //                            group = "widgets",
    //                            icon = ldk.Icon,
    //                            link = "#",
    //                            items = new List<Item>()
    //                        };

    //                        foreach (ChucNang cn in ldk.ChucNang)
    //                        {
    //                            if(cn.LaMenu)
    //                            {
    //                                if(menus.Where(x => x.title == ldk.TenLopDieuKhien && x.items.Where(y => y.title == cn.TenHienThi).Count() > 0).Count() == 0)
    //                                    tmp.items.Add(new Item
    //                                    {
    //                                        group = "apps",
    //                                        name = cn.TenChucNang,
    //                                        title = cn.TenHienThi,
    //                                        href = cn.Link,
    //                                        link = cn.LinkRouter,
    //                                        icon = cn.Icon
    //                                    });
    //                            }
    //                        }

    //                        menus.Add(tmp);
    //                    }
    //                }

    //                if (nhomchucnang.ChucNangID != null && nhomchucnang.ChucNangID != 0)
    //                {
    //                    if (nhomchucnang.ChucNang.LopDieuKhienID != null)
    //                    {
    //                        var cn = nhomchucnang.ChucNang;
    //                        if(cn.LaMenu)
    //                        {
    //                            var ldk = cn.LopDieuKhien;
    //                            var menu = menus.Where(x => x.title == ldk.TenLopDieuKhien).FirstOrDefault();
    //                            if (menu != null)
    //                            {
    //                                if(menu.items.Where(x => x.title == cn.TenHienThi).Count() == 0)
    //                                {
    //                                    menu.items.Add(new Item
    //                                    {
    //                                        group = "apps",
    //                                        name = cn.TenChucNang,
    //                                        title = cn.TenHienThi,
    //                                        href = cn.Link,
    //                                        link = cn.LinkRouter,
    //                                        icon = cn.Icon
    //                                    });
    //                                }
    //                            }
    //                            else
    //                            {
    //                                if (ldk.LopDieuKhienID != 2)
    //                                {
    //                                    var tmp = new Menu
    //                                    {
    //                                        title = ldk.TenLopDieuKhien,
    //                                        component = "widgets",
    //                                        group = "widgets",
    //                                        icon = ldk.Icon,
    //                                        link = "#",
    //                                        items = new List<Item>()
    //                                    };

    //                                    if (menus.Where(x => x.title == ldk.TenLopDieuKhien && x.items.Where(y => y.title == cn.TenHienThi).Count() > 0).Count() == 0)
    //                                        tmp.items.Add(new Item
    //                                        {
    //                                            group = "apps",
    //                                            name = cn.TenChucNang,
    //                                            title = cn.TenHienThi,
    //                                            href = cn.Link,
    //                                            link = cn.LinkRouter,
    //                                            icon = cn.Icon
    //                                        });

    //                                    menus.Add(tmp);
    //                                }
    //                            }
    //                        }
    //                    }
    //                    else
    //                    {
    //                        var cn = nhomchucnang.ChucNang;
    //                        moRong = new Menu();
    //                        moRong.title = cn.TenHienThi;
    //                        moRong.link = cn.LinkRouter;
    //                        moRong.icon = cn.Icon;
    //                        menus.Add(moRong);

    //                    }
    //                }
    //            }
    //        }
    //        List<Menu> res = new List<Menu>();

    //        return menus;
    //    }

    //    public static List<ChucNangApi> GetChucNangApi(int UserId)
    //    {
    //        if (UserId <= 0)
    //            return null;
    //        var lst = new List<ChucNangApi>();

    //        var lstChucNang = GetById(UserId);
    //        lstChucNang.ForEach(x => {
    //            if(x.ChucNangApi.Count != 0)
    //            {
    //                lst.AddRange(x.ChucNangApi);
    //            }
    //        });
    //        return lst;
    //    }
    //}
}