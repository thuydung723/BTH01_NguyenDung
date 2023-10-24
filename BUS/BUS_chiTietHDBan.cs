using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_chiTietHDBan
    {
        DAL_chiTietHDBan dalcthdb=new DAL_chiTietHDBan();
        DAL_NhanVien dalnv=new DAL_NhanVien();
        //public DataTable getHDBan()
        //{
        //    return dalcthdb.getHDBan();
        //}
        //public string LayTTHoaDon(string sql)
        //{
        //    return dalcthdb.LayTTHoaDon(sql);
        //}    
        public string LayTTHoaDonTen(string mahdb)
        {
            return dalcthdb.LayTTHoaDonTen(mahdb);
        }
        public string LayTTHoaDonTenKH(string mahdb)
        {
            return dalcthdb.LayTTHoaDonTenKH(mahdb);
        }
        public string LayTTSDTKH(string mahdb)
        {
            return dalcthdb.LayTTSDTKH(mahdb);
        }
        public DataTable getChiTietHDBan()
        {
            return dalcthdb.getChiTietHDBan();
        }
        public DataTable getNhanVien()
        {
            return dalnv.getNhanVien();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalcthdb.kiemTraMaTrung(ma);
        }
        public bool themCTHDBan(DTO_chiTietHDBan CTHDB)
        {
            return dalcthdb.themCTHDBan(CTHDB);
        }
        public bool suaCTHDBan(DTO_chiTietHDBan CTHDB)
        {
            return dalcthdb.suaCTHDBan(CTHDB);
        }
        public int SoLuongSP(string masp)
        {
            return dalcthdb.SoLuongSP(masp);
        }
        public bool KiemTraSoLuongSP(string masp,int soluongban)
        {
            int soLuongSanPham = dalcthdb.SoLuongSP(masp);
            if (soluongban < soLuongSanPham + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CapNhapSoLuongSP(string masp)
        {
            return dalcthdb.CapNhapSoLuongSP(masp);
        }
    }
}
