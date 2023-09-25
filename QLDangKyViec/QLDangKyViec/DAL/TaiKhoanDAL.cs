using QLDangKyViec.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDangKyViec.DAL
{
    public class TaiKhoanDAL
    {
        DataHelper helper = new DataHelper();

        public DataTable KiemTraTaiKhoan(DTOTaiKhoan tk)
        {
            string query = string.Format("SELECT * FROM TaiKhoan WHERE TENTAIKHOAN LIKE N'{0}' and MATKHAU LIKE N'{1}' and QUYEN LIKE N'{2}'", tk.TenTaiKhoan, tk.MatKhau, tk.MaQuyen);
            DataTable tb = helper.ExecuteQuery(query);
            try
            {
                return tb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
