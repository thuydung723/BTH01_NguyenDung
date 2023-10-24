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
    public class BUS_NhaCC
    {
        DAL_NhaCC dalncc=new DAL_NhaCC();
        public DataTable getNhaCC()
        {
            return dalncc.getNhaCC();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dalncc.kiemTraMaTrung(ma);
        }
        public bool themNhaCC(DTO_NhaCC provider)
        {
            return dalncc.themNhaCC(provider);
        }
        public bool suaNhaCC(DTO_NhaCC provider)
        {
            return dalncc.suaNhaCC(provider);
        }
        public bool xoaNhaCC(string ma)
        {
            return dalncc.xoaNhaCC(ma);
        }
        public DataTable timKiemNhaCCID(string ma)
        {
            return dalncc.timKiemNhaCCID(ma);   
        }
        public DataTable timkiemNhaCCName(string ten)
        {
            return dalncc.timKiemNhaCCName(ten);
        }
    }
}
