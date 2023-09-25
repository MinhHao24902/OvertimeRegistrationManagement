using QLDangKyViec.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Data Access Layer 
namespace QLDangKyViec
{
    class DangKyDAL
    {
        DataHelper dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public DangKyDAL()
        {
            dc = new DataHelper();
        }

        public DataTable getAllDangKy()
        {
            //Tạo một kết nối đến sql
            SqlConnection conn = dc.getConnect();
            //Mở kết nối
            conn.Open();
            //Tạo câu lệnh lấy toàn bộ người đăng ký
            string sql = "SELECT * FROM DANGKY";
            //Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, conn);
            //Đổ dữ liệu từ DataAdapter sang DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Đóng kết nối
            conn.Close();
            //Trả về DataTable
            return dt;
        }
        public bool InsertDangky(DTODangKy dk)
        {
            string sql = "INSERT INTO DANGKY(TUNGAY, DENNGAY, TUGIO, DENGIO, NGUOIDANGKY, LYDO) VALUES (@TUNGAY, @DENNGAY, @TUGIO, @DENGIO, @NGUOIDANGKY, @LYDO)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TUNGAY", SqlDbType.Date).Value = dk.TUNGAY;
                cmd.Parameters.Add("@DENNGAY", SqlDbType.Date).Value = dk.DENNGAY;
                cmd.Parameters.Add("@TUGIO", SqlDbType.NVarChar).Value = dk.TUGIO;
                cmd.Parameters.Add("@DENGIO", SqlDbType.NVarChar).Value = dk.DENGIO;
                cmd.Parameters.Add("@NGUOIDANGKY", SqlDbType.NVarChar).Value = dk.NGUOIDANGKY;
                cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = dk.LYDO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateDangky(DTODangKy dk)
        {
            string sql = "UPDATE DANGKY SET TUNGAY = @TUNGAY, DENNGAY = @DENNGAY, TUGIO = @TUGIO, DENGIO = @DENGIO, NGUOIDANGKY = @NGUOIDANGKY, LYDO = @LYDO WHERE ID = @ID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dk.ID;
                cmd.Parameters.Add("@TUNGAY", SqlDbType.Date).Value = dk.TUNGAY;
                cmd.Parameters.Add("@DENNGAY", SqlDbType.Date).Value = dk.DENNGAY;
                cmd.Parameters.Add("@TUGIO", SqlDbType.NVarChar).Value = dk.TUGIO;
                cmd.Parameters.Add("@DENGIO", SqlDbType.NVarChar).Value = dk.DENGIO;
                cmd.Parameters.Add("@NGUOIDANGKY", SqlDbType.NVarChar).Value = dk.NGUOIDANGKY;
                cmd.Parameters.Add("@LYDO", SqlDbType.NVarChar).Value = dk.LYDO;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteDangky(DTODangKy dk)
        {
            string sql = "DELETE DANGKY WHERE ID = @ID";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = dk.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiem(string dk)
        {
            string sql = "SELECT * FROM DANGKY WHERE NGUOIDANGKY LIKE '%" + dk + "%'";
            SqlConnection con = dc.getConnect();
            con.Open();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
