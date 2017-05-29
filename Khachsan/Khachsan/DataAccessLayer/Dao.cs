using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Khachsan.ValuesOject;
using Khachsan.GUI;


namespace Khachsan.DataAccessLayer
{
    class Dao
    {
        //LẤY RA DỮ LIỆU TỪ CÁC BẢNG TRONG CSDL
        #region
        public static DataTable Getlistthietbi()
        {
            return DataProvider.GetData("select * from danhsachthietbi");
        }
        public static DataTable Getlistloaithietbi()
        {
            return DataProvider.GetData("select *from loaithietbi");
        }
        public static DataTable Getlistnguoidung()
        {
            return DataProvider.GetData("select*from nguoidung");
        }
        public static DataTable Getlistchucvu()

        {
            return DataProvider.GetData("select * from chucvu");
        }
        public static DataTable Getlistnhanvien()
        {
            return DataProvider.GetData("select *from nhanvien");
        }
        public static DataTable Getlistkhachhang()
        {
            return DataProvider.GetData("select *from khachhang");
        }
        public static DataTable Getlistphong()
        {
            return DataProvider.GetData("select * from phong");
        }
        public static DataTable Getlistloaiphong()
        {
            return DataProvider.GetData("select * from loaiphong");
        }
        public static DataTable Getlistphieudangki()
        {
            return DataProvider.GetData("select *from phieuthuephong");
        }
        public static DataTable Getlistphieudichvu()
        {
            return DataProvider.GetData("select * from dichvu");
        }
        public static DataTable Getlisthoadon()
        {
            return DataProvider.GetData("select* from hoadon");
        }
        public static DataTable Getlistchitietthuephong()
        {
            return DataProvider.GetData("select *from chitietthuephong");
        }
        public static DataTable Getlistchitietdungdichvu()
        {
            return DataProvider.GetData("select *from chitietdungdichvu");
        }
        public static DataTable Getlistchitietthietbi()
        {
            return DataProvider.GetData("select *from chitietsudungthietbi");
        }
      
        #endregion

        //KHÁCH HÀNG
        #region
        public static int InsertProfile(khachhang k)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makhachhang",k.makhachhang),
                new SqlParameter("@ten",k.tenkhachhang),
                new SqlParameter("@dc",k.diachi),
                new SqlParameter("@sdt",k.sodienthoai),
                new SqlParameter("@cmt",k.CMT),
                new SqlParameter("@quoctich",k.quoctich),
                new SqlParameter("@ngaysinh",k.ngaysinh),
                new SqlParameter("@gioitinh",k.gioitinh)
            };
            return DataProvider.ExecuteNonQuery("themkhachhang", para);
        }
        public static int UpdateProfile(khachhang k)

        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh",k.makhachhang),
                 new SqlParameter("@ten",k.tenkhachhang),
                new SqlParameter("@dc",k.diachi),
                new SqlParameter("@sdt",k.sodienthoai),
            };
            return DataProvider.ExecuteNonQuery("suakhachhang", para);
        }
        public static int DeleteProfile(khachhang k)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@makh",k.makhachhang)
            };
            return DataProvider.ExecuteNonQuery("xoakhachhang", para);
        }
        public static DataTable Timkiemkhachhang(string ten)
        {
            return DataProvider.GetData("select *from khachhang" + ten);
        }
        public static int Xemkh(khachhang k)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",k.makhachhang)
            };
            return DataProvider.ExecuteNonQuery("xemkhachhang", para);
        }
        #endregion

        //DỊCH VỤ
        #region
        public static int InsertProfile(dichvu d)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madichvu",d.madichvu),
                new SqlParameter("@tendichvu",d.tendichvu),
                new SqlParameter("giadichvu",d.giadichvu),
            };
            return DataProvider.ExecuteNonQuery("themdichvu", para);
        }
        public static int UpdateProfile(dichvu d)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madichvu",d.madichvu),
                new SqlParameter("@giadichvu",d.giadichvu),
                new SqlParameter("@tendichvu",d.tendichvu)
            };
            return DataProvider.ExecuteNonQuery("suadichvu", para);
        }
        public static int DeleteProfile(dichvu d)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madichvu",d.madichvu)
            };
            return DataProvider.ExecuteNonQuery("xoadichvu", para);
        }
        public static DataTable Timkiemdichvu(string name)
        {
            return DataProvider.GetData("select *from dichvu" + name);
        }
        #endregion

        //PHÒNG
        #region
        public static int UpdateProfile(phong ph)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",ph.maphong),
                new SqlParameter("@giaphong",ph.giaphong)
            };
            return DataProvider.ExecuteNonQuery("suaphong", para);
        }
        public static int InsertProfile(phong ph)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",ph.maphong),
                new SqlParameter("@maloaiphong",ph.maloaiphong),
                new SqlParameter("@giaphong",ph.giaphong),
                new SqlParameter("@tinhtrangphong",ph.tinhtrangphong)
            };
            return DataProvider.ExecuteNonQuery("themphong", para);
        }
        public static int DeleteProfile(phong ph)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",ph.maphong)
            };
            return DataProvider.ExecuteNonQuery("xoaphong", para);
        }
        public static DataTable Xemdanhsachphong(string maloai)
        {
            return DataProvider.GetData("select*from phong" + maloai);
        }
        public static DataTable Xemchitietphong(string maphong)
        {
            return DataProvider.GetData("select *from phong" + maphong);
        }
        #endregion

        //HÓA ĐƠN
        #region
        public static int InsertProfile(hoadon hd)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                   new SqlParameter("@mahd",hd.mahoadon),
                   new SqlParameter("@manv",hd.manhanvien),
                   new SqlParameter("@makh",hd.makhachhang),
                   new SqlParameter("@maphieu",hd.maphieu),
                   new SqlParameter("@giaphong",hd.giaphong),
                   new SqlParameter("@giadv",hd.giadichvu),
                   new SqlParameter("@ngaythanhtoan",hd.ngaythanhtoan),
                   new SqlParameter("@tongtien",hd.tongtien),
                
                };
            return DataProvider.ExecuteNonQuery("themhoadon", para);

        }
        public static int UpdateProfile(hoadon hd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                   new SqlParameter("@mahoadon",hd.mahoadon),
                   new SqlParameter("@giaphong",hd.giaphong),
                   new SqlParameter("@giadv",hd.giadichvu),
                   new SqlParameter("@tongtien",hd.tongtien)
            };
            return DataProvider.ExecuteNonQuery("suahoadon", para);
        }
        public static int DeleteProfile(hoadon hd)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@mahoadon",hd.mahoadon)
                };
            return DataProvider.ExecuteNonQuery("xoahoadon", para);
        }
        public static DataTable Timkiemhoadon(string ma)
        {
            return DataProvider.GetData("select * from hoadon" + ma);
        }
        public static int Xemphieu(hoadon h)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",h.maphieu)
            };
            return DataProvider.ExecuteNonQuery("xemphieudk", para);
        }
        public static int Tinhsongay(hoadon h,phieudangki p)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",h.maphieu),
                new SqlParameter("@mahoadon",h.mahoadon),
                new SqlParameter("@maphieu",p.maphieu)
            };
            return DataProvider.ExecuteNonQuery("tinhsongay", para);
        }
        #endregion

        //PHIẾU ĐĂNG KÍ
        #region
        public static int InsertProfile(phieudangki p)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                   new SqlParameter("@maphieu",p.maphieu),
                   new SqlParameter("@manhanvien",p.manhanvien),
                   new SqlParameter("@makhachhang",p.makhachhang),
                   new SqlParameter("@songuoio",p.songuoio),
                   new SqlParameter("@ngaydat",p.ngaydatphong),
                   new SqlParameter("@ngaytra",p.ngaytraphong),
                   new SqlParameter("@ngaydukien",p.ngaydukientraphong),
                   new SqlParameter("@maphong",p.maphong)
                };
            return DataProvider.ExecuteNonQuery("themphieu", para);
        }
        public static int UpdateProfile(phieudangki p)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                   new SqlParameter("@maphieu",p.maphieu),
                   new SqlParameter("@ngaytra",p.ngaytraphong)
                };
            return DataProvider.ExecuteNonQuery("suaphieu", para);
        }
        public static int DeleteProfile(phieudangki p)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                   new SqlParameter("@maphieu",p.maphieu),
                   new SqlParameter("@maphong",p.maphong)
                };
            return DataProvider.ExecuteNonQuery("xoaphieu", para);
        }
        public static DataTable Timkiemphieuthuephong(string ma)
        {
            return DataProvider.GetData("select*from phieuthuephong" + ma);
        }

    #endregion

        //NHÂN VIÊN
        #region
    public static int ThemMoi(nhanvien n)
        {
            SqlParameter[] para = new SqlParameter[]
            {
             new SqlParameter("@manhanvien",n.manhanvien),
             new SqlParameter("@diachi",n.diachi),
             new SqlParameter("@hoten",n.tennhanvien),
             new SqlParameter("@soDT",n.sodienthoai),
             new SqlParameter("@machucvu",n.machucvu),
             new SqlParameter("@ngaysinh",n.ngaysinh),
             new SqlParameter("@gioitinh",n.gioitinh)
            };
            return DataProvider.ExecuteNonQuery("themnhanvien", para);
        }
    public static int UpdateProfile(nhanvien n)
    {
        SqlParameter[] para = new SqlParameter[]
        {
            new SqlParameter("@manhanvien",n.manhanvien),
            new SqlParameter("@diachi",n.diachi),
            new SqlParameter("@hoten",n.tennhanvien),
            new SqlParameter("@soDT",n.sodienthoai)
        };
        return DataProvider.ExecuteNonQuery("suanhanvien", para);

    }
    public static int DeleteProfile(nhanvien n)
    {
        SqlParameter[] para = new SqlParameter[]
        {
            new SqlParameter("@manhanvien",n.manhanvien)
        };
        return DataProvider.ExecuteNonQuery("xoanhanvien", para);
    }
    public static DataTable Timkiemnhanvien(string ten)
    {
        return DataProvider.GetData("select *from nhanvien" + ten);
    }
        public static DataTable Xemnhanvien(string machucvu)
        {
            return DataProvider.GetData("select *from nhanvien" + machucvu);
        }
        #endregion
        //THIẾT BỊ
        #region
        public static int InsertProfile(thietbi t)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathietbi",t.mathietbi),
                new SqlParameter("@tenthietbi",t.tenthietbi),
                new SqlParameter("@maloai",t.maloaithietbi),
                new SqlParameter("@gia",t.giathietbi)
            };
            return DataProvider.ExecuteNonQuery("themthietbi", para);
        }
        public static int UpdateProfile(thietbi t)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathietbi",t.mathietbi),
                new SqlParameter("@gia",t.giathietbi)
            };
            return DataProvider.ExecuteNonQuery("suathietbi", para);
        }
        public static int DeleteProfile(thietbi t)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathietbi",t.mathietbi)
            };
            return DataProvider.ExecuteNonQuery("xoathietbi", para);
        }
        public static DataTable Xemdanhsachthietbi(string maloai)
        {
            return DataProvider.GetData("select * from danhsachthietbi"+maloai);
        }
        #endregion
        //CHI TIẾT THIẾT BỊ
        #region
        public static int InsertProfile(chitietsudungthietbi c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathietbi",c.mathietbi),
                new SqlParameter("@maphong",c.maphong),
                new SqlParameter("@tenthietbi",c.tenthietbi)
            };
            return DataProvider.ExecuteNonQuery("themchitiet", para);
        }
        public static int UpdateProfile(chitietsudungthietbi c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathietbi",c.mathietbi),
                new SqlParameter("@maphong",c.maphong),
                new SqlParameter("@tenthietbi",c.tenthietbi)
            };
            return DataProvider.ExecuteNonQuery("suachitiet", para);
        }
        public static DataTable Hienthidv(string ma)
        {
            return DataProvider.GetData("select * from chitietsudungthietbi" + ma);
        }
        #endregion
        //CHI TIẾT DỊCH VỤ
        #region 
        public static int InsertProfile (chitietsudungdichvu c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madichvu",c.madichvu),
                new SqlParameter("@maphieu",c.maphieu),
                new SqlParameter("@tendichvu",c.tendichvu),
                new SqlParameter("@giadichvu",c.giadichvu)
            };
            return DataProvider.ExecuteNonQuery("themnguoidungdichvu", para);
        }
        public static int UpdateProfile(chitietsudungdichvu c)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@madichvu",c.madichvu),
                new SqlParameter("@maphieu",c.maphieu),
                new SqlParameter("@tendichvu",c.tendichvu),
                new SqlParameter("@giadichvu",c.giadichvu)
            };
            return DataProvider.ExecuteNonQuery("suanguoidungdichvu", para);
        }
        public static DataTable Hienthi(string ma)
        {
            return DataProvider.GetData("select * from chitietdungdichvu" + ma);
        }
        #endregion
    }
}