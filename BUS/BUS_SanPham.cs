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
    public  class BUS_SanPham
    {
        DAL_SanPham dalsp = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dalsp.getSanPham();
        }
        public DataTable getLoaiSanPham()
        {
            return dalsp.getLoaiSanPham();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalsp.kiemTraMaTrung(ma);
        }
        public bool themSanPham(DTO_SanPham product)
        {
            return dalsp.themSanPham(product);
        }
        public bool suaSanPham(DTO_SanPham product)
        {
            return dalsp.suaSanPham(product);
        }
        public bool xoaSanPham(string ma)
        {
            return dalsp.xoaSanPham(ma);
        }
        public DataTable timKiemSanPhamID(string ma)
        {
            return dalsp.timKiemSanPhamID(ma);
        }
        public DataTable timKiemSanPhamName(string ten)
        {
            return dalsp.timKiemSanPhamName(ten);
        }
    }
}
