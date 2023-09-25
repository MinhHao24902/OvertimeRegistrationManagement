using QLDangKyViec.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Business Logic Layer
namespace QLDangKyViec
{
    class DangKyBLL
    {
        DangKyDAL dalDK;
        public DangKyBLL()
        {
            dalDK = new DangKyDAL();
        }
        public DataTable getAllDangKy()
        {
            return dalDK.getAllDangKy();
        }
        public bool InsertDangKy(DTODangKy dk)
        {
            return dalDK.InsertDangky(dk);
        }
        public bool UpdateDangKy(DTODangKy dk)
        {
            return dalDK.UpdateDangky(dk);
        }
        public bool DeleteDangKy(DTODangKy dk)
        {
            return dalDK.DeleteDangky(dk);
        }
        public DataTable TimKiem(string dk)
        {
            return dalDK.TimKiem(dk);
        }
    }
}
