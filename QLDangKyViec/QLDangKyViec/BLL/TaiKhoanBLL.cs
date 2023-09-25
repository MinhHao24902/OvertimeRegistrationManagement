using QLDangKyViec.DAL;
using QLDangKyViec.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDangKyViec.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();
        public DataTable KiemTraTaiKhoan(DTOTaiKhoan tk)
        {
            return dal.KiemTraTaiKhoan(tk);
        }
    }
}
