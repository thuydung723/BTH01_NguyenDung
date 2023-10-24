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
    public class BUS_QL_KhoHang
    {
        DAL_QL_KhoHang dalkho = new DAL_QL_KhoHang();
        public DataTable getKhoHang()
        {
            return dalkho.getKhoHang();
        }
        DAL_NhaCC dalncc = new DAL_NhaCC();
        public DataTable getNhaCC()
        {
            return dalncc.getNhaCC();
        }
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dalnv.getNhanVien();
        }
        //Mới
        public DataTable LayDSKhoHang()
        {
            return dalkho.LayDSKhoHang();
        }
        public string LayTTTenNCC(string mancc)
        {
            return dalkho.LayTTTenNCC(mancc);
        }
        //Mới
        public int kiemTraMaTrung(string ma)
        {
            return dalkho.kiemTraMaTrung(ma);
        }
        public bool themKhoHang(DTO_QL_KhoHang warehouse)
        {
            return dalkho.themKhoHang(warehouse);
        }
        public bool suaKhoHang(DTO_QL_KhoHang warehouse)
        {
            return dalkho.suaKhoHang(warehouse);
        }
        public bool xoaKhoHang(string ma)
        {
            return dalkho.xoaKhoHang(ma);
        }
        public DataTable timKiemKhoID(string ma)
        {
            return dalkho.timKiemKhoID(ma);
        }
        public DataTable timKiemKhoName(string ten)
        {
            return dalkho.timKiemKhoName(ten);
        }
    }
}
