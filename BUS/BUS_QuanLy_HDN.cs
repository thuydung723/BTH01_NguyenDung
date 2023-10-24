using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using Excel= Microsoft.Office.Interop.Excel;

namespace BUS
{
    
    public class BUS_QuanLy_HDN
    {
        DAL_QuanLy_HDN dalhdn=new DAL_QuanLy_HDN();
        DAL_NhanVien dalnv = new DAL_NhanVien();
        DAL_QL_KhoHang dalkho=new DAL_QL_KhoHang();
        public DataTable getHDNhap()
        {
            return dalhdn.getHDNhap();
        }
        public DataTable getNhanVien()
        {
            return dalnv.getNhanVien();
        }
        public DataTable getKhoHang()
        {
            return dalkho.getKhoHang();
        }
        public DataTable LayDSHDN()
        {
            return dalhdn.LayDSHDNhap();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalhdn.kiemTraMaTrung(ma);
        }
      
        public bool themHDNhap(DTO_QuanLy_HDN Bill)
        {
            return dalhdn.themHDNhap(Bill);
        }
        public bool suaHDNhap(DTO_QuanLy_HDN Bill)
        {
            return dalhdn.suaHDNhap(Bill);
        }
        public bool xoaHDNhap(string ma)
        {
            return dalhdn.xoaHDNhap(ma);
        }
        public string GetTenNhanVienByMa(string manv)
        {
            return dalhdn.GetTenNhanVienByMa(manv);
        }
        public DataTable timKiemHDID(string ma)
        {
            return dalhdn.timKiemHDID(ma);
        }
        public DataTable timKiemHDIDKho(string makho)
        {
            return dalhdn.timKiemHDIDKho(makho);
        }
        //Mới
        public DataTable timKiemHDTG(DateTime startDate, DateTime endDate)
        {
            return dalhdn.timKiemHDTG(startDate,endDate);
        }
        public bool CapNhapSoLuongSP(string mahdn)
        {
            return dalhdn.CapNhapSoLuongSP(mahdn);
        }
        //Mới
        //Xuất file excel
        public DataTable InTTHDN(string mahdn)
        {
            return dalhdn.InTTHDN(mahdn);
        }
        public void ExportToExcel(DataTable dataTable,string duongdan,string mahdn,string tennv, string tongTien,string printime)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Cells[1,6] = "HÓA ĐƠN NHẬP";
            worksheet.Cells[3,1] = "Mã hóa đơn nhập: " + mahdn;
            worksheet.Cells[4, 1] = "Nhân viên nhập :" + tennv;
            worksheet.Cells[5,1] = "Tổng tiền hóa đơn: " + tongTien;
            worksheet.Cells[6,1] = "Thời gian in hóa đơn: " + DateTime.Now.ToString();

            for (int i = 1; i <= dataTable.Columns.Count; i++)
            {
                worksheet.Cells[8, i] = dataTable.Columns[i - 1].ColumnName;
            }

            for (int i = 1; i <= dataTable.Rows.Count; i++)
            {
                for (int j = 1; j <= dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 8, j] = dataTable.Rows[i - 1][j - 1].ToString();
                }
            }
            //worksheet.Cells[1, dataTable.Columns.Count + 2] = "Mã hóa đơn nhập: " + mahdn;
            //worksheet.Cells[2, dataTable.Columns.Count + 2] = "Tổng tiền hóa đơn: " + tongTien;
            //worksheet.Cells[3, dataTable.Columns.Count + 2] = "Thời gian in hóa đơn: " + DateTime.Now.ToString();
            workbook.SaveAs(duongdan);
            workbook.Close();
            excel.Quit();
        }
    }
}




