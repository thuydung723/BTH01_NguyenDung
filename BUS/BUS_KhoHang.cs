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
    public class BUS_KhoHang
    {
        DAL_KhoHang dalkho = new DAL_KhoHang();
        public DataTable getKhoHang()
        {
            return dalkho.getKhoHang();
        }
        public DataTable getCTKhoHang()
        {
            return dalkho.getCTKhoHang();
        }
        public string LayTTTenKHo(string makho)
        {
            return dalkho.LayTTTenKHo(makho);
        }
        public string LayTTNCC(string makho)
        {
            return dalkho.LayTTNCC(makho);
        }
        public string LayTTNV(string makho)
        {
            return dalkho.LayTTNV(makho);
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalkho.kiemTraMaTrung(ma);
        }
        //public bool xoaKhoHang(string ma)
        //{
        //    return dalkho.xoaCTKhoHang(ma);
        //}
        public bool themCTKhoHang(DTO_KhoHang DSCTKho)
        {
            return dalkho.themCTKhoHang(DSCTKho);
        }
        public bool suaCTKhoHang(DTO_KhoHang DSCTKho)
        {
            return dalkho.suaCTKhoHang(DSCTKho);
        }
    }
}
