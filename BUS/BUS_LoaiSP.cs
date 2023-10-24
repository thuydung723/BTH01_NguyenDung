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
    public class BUS_LoaiSP
    {
        DAL_LoaiSP dallsp = new DAL_LoaiSP();
        public DataTable getLoaiSP()
        {
            return dallsp.getLoaiSP();
        }
        public int kiemTraMaTrung(string ma)
        {
            return dallsp.kiemTraMaTrung(ma);
        }
        public bool themLoaiSP(DTO_LoaiSP LoaiSP)
        {
            return dallsp.themLoaiSP(LoaiSP);
        }
        public bool UpdateLoaiSP(DTO_LoaiSP loaiSP)
        {
            return dallsp.UpdateLoaiSP(loaiSP);
        }
        public bool xoaLoaiSP(string ma)
        {
            return dallsp.xoaLoaiSP(ma);
        }
    }
}
