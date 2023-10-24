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
    public class BUS_CTHDNhap
    {
        DAL_CTHDNhap dalcthdn = new DAL_CTHDNhap();
        DAL_NhanVien dalnv = new DAL_NhanVien();
        DAL_QL_KhoHang dalkho = new DAL_QL_KhoHang();
        DAL_SanPham dalsp = new DAL_SanPham();
        public DataTable getHDNhap()
        {
            return dalcthdn.getHDNhap();
        }
        //Mới

        public DataTable getCTHDNhap()
        {
            return dalcthdn.getCTHDNhap();
        }
        public DataTable getSanPham()
        {
            return dalsp.getSanPham();
        }
        public DataTable getKhoHang()
        {
            return dalkho.getKhoHang();
        }
        public DataTable getNhanVien()
        {
            return dalnv.getNhanVien();
        }
        public string LayTTHoaDonTenNV(string mahdn)
        {
            return dalcthdn.LayTTHoaDonTenNV(mahdn);
        }
        public string LayTTHoaDonTenKho(string mahdn)
        {
            return dalcthdn.LayTTHoaDonTenKho(mahdn);
        }    
        public int kiemTraMaTrung(string ma)
        {
            return dalcthdn.kiemTraMaTrung(ma);
        }
        public bool themCTHDNhap(DTO_CTHDNhap CTHDN)
        {
            return dalcthdn.themCTHDNhap(CTHDN);
        }
        public bool suaCTHDNhap(DTO_CTHDNhap CTHDN)
        {
            return dalcthdn.suaCTHDNhap(CTHDN);
        }
        //Mới
        public int SoLuongSPKho(string masp)
        {
            return dalcthdn.SoLuongSPKho(masp);
        }
        public bool KiemTraSoLuongSP(string masp, int soLuongNhap)
        {
            int soLuongTrongKho = dalcthdn.SoLuongSPKho(masp);
            if (soLuongNhap < soLuongTrongKho + 1)
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
            return dalcthdn.CapNhapSoLuongSP(masp);
        }
        //Hàm cập nhật số lượng từ chi tiết hóa đơn vào bảng sản phẩm
        public bool CapNhatSoLuongSP1(string masp)
        {
            return dalcthdn.CapNhatSoLuongSP1(masp);
        }
        //Mới
    }
}
