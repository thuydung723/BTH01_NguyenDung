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
    public class BUS_Logins
    {
        DAL_Logins daldn = new DAL_Logins();
        public bool KiemTraTaiKhoan(string user, string pass)
        {
            DataTable dt = daldn.getDangNhap();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["UserName"].ToString() == user && dr["Password"].ToString() == pass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
