using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Khachsan.DataAccessLayer;
using Khachsan.ValuesOject;

namespace Khachsan.BusinessLogiclayer
{
    class Bus
    {
        #region
        public static DataTable Getlistphieudangki()
        {
            return Dao.Getlistphieudangki();
        }
        public static DataTable Getlistphieudichvu()
        {
            return Dao.Getlistphieudichvu();
        }
        public static DataTable Getlistchucvu()
        {
            return Dao.Getlistchucvu();
        }
        public static DataTable Getlistnhanvien()
        {
            return Dao.Getlistnhanvien();
        }
        public static DataTable Getlistloaiphong()
        {
            return Dao.Getlistloaiphong();
        }
        public static DataTable Getlistphong()
        {
            return Dao.Getlistphong();
        }
        public static DataTable Getlistkhachhang()
        {
            return Dao.Getlistkhachhang();
        }
        public static DataTable Getlisthoadon()
        {
            return Dao.Getlisthoadon();
        }
        public static DataTable Getlistthietbi()
        {
            return Dao.Getlistthietbi();
        }
        public static DataTable Getlistloaithietbi()
        {
            return Dao.Getlistloaithietbi();
        }
        public static DataTable Getlistchitietdungdichvu()
        {
            return Dao.Getlistchitietdungdichvu();
        }
        public static DataTable Getlistchitietthietbi()
        {
            return Dao.Getlistchitietthietbi();
        }
        #endregion
        //KHÁCH HÀNG
        #region
        public static int InsertProfile(khachhang k)
        {
            return Dao.InsertProfile(k);
        }
        public static int UpdateProfile(khachhang k)
        {
            return Dao.UpdateProfile(k);
        }
        public static int DeleteProfile(khachhang k)
        {
            return Dao.DeleteProfile(k);
        }
        public static DataTable Timkiemkhachhang(string ten)
        {
            return Dao.Timkiemkhachhang(ten);
        }
        public static int Xemkh(khachhang k)
        {
            return Dao.Xemkh(k);
        }
        #endregion
        //DỊCH VỤ
        #region
        public static int InsertProfile(dichvu d)
        {
            return Dao.InsertProfile(d);
        }
        public static int UpdateProfile(dichvu d)
        {
            return Dao.UpdateProfile(d);
        }
        public static int DeleteProfile(dichvu d)
        {
            return Dao.DeleteProfile(d);
        }
        public static DataTable Timkiemdichvu(string name)
        {
            return Dao.Timkiemdichvu(name);
        }
        #endregion
        //PHÒNG
        #region
        public static int UpdateProfile(phong ph)
        {
            return Dao.UpdateProfile(ph);
        }
        public static int InsertProfile(phong ph)
        {
            return Dao.InsertProfile(ph);
        }
        public static int DeleteProfile(phong ph)
        {
            return Dao.DeleteProfile(ph);
        }
        public static DataTable Xemdanhsachphong(string maloai)
        {
            return Dao.Xemdanhsachphong(maloai);
        }
        public static DataTable Xemchitietphong(string maphong)
        {
            return Dao.Xemchitietphong(maphong);
        }

        #endregion
        //HÓA ĐƠN
        #region
        public static int InsertProfile(hoadon hd)
        {
            return Dao.InsertProfile(hd);
        }
        public static int UpdateProfile(hoadon hd)
        {
            return Dao.UpdateProfile(hd);
        }
        public static int DeleteProfile(hoadon hd)
        {
            return Dao.DeleteProfile(hd);
        }
        public static DataTable Timkiemhoadon(string ma)
        {
            return Dao.Timkiemhoadon(ma);
        }
        public static int Xemphieu(hoadon h)
        {
            return Dao.Xemphieu(h);
        }
        public static int Tinhsongay(hoadon h,phieudangki p)
        {
            return Dao.Tinhsongay(h,p);
        }
        #endregion
        //PHIẾU THUÊ PHÒNG
        #region
        public static int InsertProfile(phieudangki p)
        {
            return Dao.InsertProfile(p);
        }
        public static int UpdateProfile(phieudangki p)
        {
            return Dao.UpdateProfile(p);
        }
        public static int DeleteProfile(phieudangki p)
        {
            return Dao.DeleteProfile(p);
        }
        public static DataTable Timkiemphieuthuephong(string ma)
        {
            return Dao.Timkiemphieuthuephong(ma);
        }
        #endregion
        //NHÂN VIÊN
        #region
        public static int ThemMoi(nhanvien n)
        {
            return Dao.ThemMoi(n);
        }
        public static int UpdateProfile(nhanvien n)
        {
            return Dao.UpdateProfile(n);
        }
       public static int DeleteProfile(nhanvien n)
        {
            return Dao.DeleteProfile(n);
        }
        public static DataTable Timkiemnhanvien(string ten)
        {
            return Dao.Timkiemnhanvien(ten);
        }
        public static DataTable Xemnhanvien(string machucvu)
        {
            return Dao.Xemnhanvien(machucvu);
        }
        #endregion
        // THIẾT BỊ
        #region
        public static int InsertProfile(thietbi t)
        {
            return Dao.InsertProfile(t);
        }
        public static int UpdateProfile(thietbi t)
        {
            return Dao.UpdateProfile(t);
        }
        public static int DeleteProfile(thietbi t)
        {
            return Dao.DeleteProfile(t);
        }
        public static DataTable Xemdanhsachthietbi(string maloai)
        {
            return Dao.Xemdanhsachthietbi(maloai);
        }
        #endregion
        //CHI TIẾT THIẾT BỊ
        #region
        public static int InsertProfile(chitietsudungthietbi c)
        {
            return Dao.InsertProfile(c);
        }
        public static int UpdateProfile(chitietsudungthietbi c)
        {
            return Dao.UpdateProfile(c);
        }
        public static DataTable Hienthidv(string ma)
        {
            return Dao.Hienthidv(ma);
        }
        #endregion
        //CHI TIẾT DỊCH VỤ
        #region
        public static int InsertProfile (chitietsudungdichvu c)
        {
            return Dao.InsertProfile(c);
        }
        public static int UpdateProfile(chitietsudungdichvu c)
        {
            return Dao.UpdateProfile(c);
        }
        public static DataTable Hienthi(string ma)
        {
            return Dao.Hienthi(ma);
        }
        #endregion
    }
}
