using QLDangKyViec.BLL;
using QLDangKyViec.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDangKyViec.GUI
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc là bạn muốn thoát không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }
        DTOTaiKhoan GetTaiKhoanInfo()
        {
            DTOTaiKhoan tk = new DTOTaiKhoan();

            tk.TenTaiKhoan = txtTaiKhoan.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            if (chkVIP.Checked)
                tk.MaQuyen = 0;
            else
                tk.MaQuyen = 1;

            return tk;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.KiemTraTaiKhoan(GetTaiKhoanInfo());

            int count = dt.Rows.Count;

            if (count > 0 && chkVIP.Checked)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMain mn = new frmMain();
                mn.ShowDialog();
            }
            else if (count == 0 && chkVIP.Checked)
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkVIP.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn quyền và thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            this.txtMatKhau.PasswordChar = '*';
        }
    }
}
