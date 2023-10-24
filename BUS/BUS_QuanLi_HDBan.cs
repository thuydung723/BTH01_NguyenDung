using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using  Excel = Microsoft.Office.Interop.Excel;

namespace BUS
{
    public class BUS_QuanLi_HDBan
    {
        DAL_QuanLi_HDBan dalhdb=new DAL_QuanLi_HDBan();
        DAL_NhanVien dalnv=new DAL_NhanVien();
        public DataTable getHDBan()
        {
            return dalhdb.getHDBan();
        }
        public DataTable getNhanVien()
        {
            return dalhdb.getNhanVien();
        }
        public DataTable LayDSHDBan()
        {
            return dalhdb.LayDSHDBan();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalhdb.kiemTraMaTrung(ma);
        }
        public DataTable getKhachHangByMaKH(string makh)
        {
            return dalhdb.getKhachHangByMaKH(makh);
        }

        public bool KiemTraTonTaiKH(string makh)
        {
            DataTable dt = dalhdb.getKhachHangByMaKH(makh);
            return dt.Rows.Count > 0;
        }
        public bool themHDBanMoi(DTO_QuanLi_HDBan Bill)
        {
            return dalhdb.themHDBanMoi(Bill);
        }
        public DataTable InTTHDBan(string makh)
        {
            return dalhdb.InTTHDBan(makh);
        }
        public string LayTTTenKH(string makh)
        {
            return dalhdb.LayTTTenKH(makh);
        }
        public string LayTTSDTKH(string makh)
        {
            return dalhdb.LayTTSDTKH(makh);
        }
        public string GetTenNhanVienByMa(string manv)
        {
            return dalhdb.GetTenNhanVienByMa(manv);
        }
        public bool suaHDBan(DTO_QuanLi_HDBan Bill)
        {
            return dalhdb.suaHDBan(Bill);
        }
        public bool xoaHDBan(string ma)
        {
            return dalhdb.xoaHDBan(ma);
        }
        public DataTable timKiemHDID(string ma)
        {
            return dalhdb.timKiemHDID(ma);
        }
        public DataTable timKiemHDIDKH(string makh)
        {
            return dalhdb.timKiemHDIDKH(makh);
        }
        //Mới
        public DataTable timKiemHDTG(DateTime startDate, DateTime endDate)
        {
            return dalhdb.timKiemHDTG(startDate, endDate);
        }
        public bool CapNhapSoLuongSP(string mahdb)
        {
            return dalhdb.CapNhapSoLuongSP(mahdb);
        }
        public void ExportToExcel(DataTable dataTable, string duongdan, string mahdb,string tennv,string tenkh, string tongTien, string printime)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Cells[1,6] = "HÓA ĐƠN BÁN";
            worksheet.Cells[3,1] = "Mã hóa đơn bán: " + mahdb;
            worksheet.Cells[4,1] = "Nhân viên: " + tennv;
            worksheet.Cells[5,1] = "Khách hàng: " + tenkh;
            worksheet.Cells[6,1] = "Tổng tiền: " + tongTien;
            worksheet.Cells[7,1] = "Thời gian in hóa đơn: " + DateTime.Now.ToString();

            for (int i = 1; i <= dataTable.Columns.Count; i++)
            {
                worksheet.Cells[9, i] = dataTable.Columns[i - 1].ColumnName;
            }

            for (int i = 1; i <= dataTable.Rows.Count; i++)
            {
                for (int j = 1; j <= dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 9, j] = dataTable.Rows[i - 1][j - 1].ToString();
                }
            }
            workbook.SaveAs(duongdan);
            workbook.Close();
            excel.Quit();
        }
    }
}
