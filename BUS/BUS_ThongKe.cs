using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace BUS
{
    public class BUS_ThongKe
    {
        DAL_ThongKe daltk = new DAL_ThongKe();
        public DataTable LayDSHDBan()
        {
            return daltk.LayDSHDBan();
        }
        public DataTable timKiemHDTGNgay(DateTime ngay)
        {
            return daltk.timKiemHDTGNgay(ngay);
        }
        public DataTable timKiemHDTG(DateTime startDate, DateTime endDate)
        {
            return daltk.timKiemHDTG(startDate, endDate);
        }
        public DataTable SanPhamBanChay()
        {
            return daltk.SanPhamBanChay();
        }
        public DataTable SanPhamTonKho()
        {
            return daltk.SanPhamTonKho();
        }
        public void ExportToExcel(DataTable dataTable, string duongdan, string printime)
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            worksheet.Cells[1,3] = "THỐNG KÊ DANH SÁCH HÓA ĐƠN BÁN THEO(THÁNG,NGÀY)";
            worksheet.Cells[3,1] = "Thời gian in thống kê: " + DateTime.Now.ToString();

            for (int i = 1; i <= dataTable.Columns.Count; i++)
            {
                worksheet.Cells[5,i] = dataTable.Columns[i - 1].ColumnName;
            }

            for (int i = 1; i <= dataTable.Rows.Count; i++)
            {
                for (int j = 1; j <= dataTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 5, j] = dataTable.Rows[i - 1][j - 1].ToString();
                }
            }
            workbook.SaveAs(duongdan);
            workbook.Close();
            excel.Quit();
        }
        
    }
}

