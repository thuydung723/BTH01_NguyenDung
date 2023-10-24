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
   public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dalnv.getNhanVien();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalnv.kiemTraMaTrung(ma);
        }
        public bool themNhanVien(DTO_NhanVien employee)
        {
            return dalnv.themNhanVien(employee);
        }
        public bool suaNhanVien(DTO_NhanVien employee)
        {
            return dalnv.suaNhanVien(employee);
        }
        public bool xoaNhanVien(string ma)
        {
            return dalnv.xoaNhanVien(ma);
        }
        public DataTable timKiemNhanVienID(string ma)
        {
            return dalnv.timKiemNhanVienID(ma);
        }
        public DataTable timKiemNhanVienName(string ten)
        {
            return dalnv.timKiemNhanVienName(ten);
        }
    }
}
