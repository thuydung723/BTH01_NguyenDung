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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkh = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalkh.getKhachHang();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalkh.kiemTraMaTrung(ma);
        }
        public bool themKhachHang(DTO_KhachHang client)
        {
            return dalkh.themKhachHang(client);
        }
        public bool suaKhachHang(DTO_KhachHang  client)
        {
            return dalkh.suaKhachHang(client);
        }
        public bool xoaKhachHang(string ma)
        {
            return dalkh.xoaKhachHang(ma);
        }
        public DataTable timKiemKhachHangID(string ma)
        {
            return dalkh.timKiemKhachHangID(ma);
        }
        public DataTable timKiemKhachHangName(string ten)
        {
            return dalkh.timKiemKhachHangName(ten);
        }

    }
}
