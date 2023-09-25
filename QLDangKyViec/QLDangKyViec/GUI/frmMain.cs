using Microsoft.Reporting.WinForms;
using QLDangKyViec.DTO;
using QLDangKyViec.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDangKyViec
{
    public partial class frmMain : Form
    {
        DangKyBLL bllDK;
        int ID;
        public frmMain()
        {
            InitializeComponent();
            bllDK = new DangKyBLL();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Có chắc là bạn muốn thoát không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }
        public void ShowAllDangKy()
        {
            DataTable dt = bllDK.getAllDangKy();
            dtgDangKy.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllDangKy();
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(dateTuNgay.Text))
            {
                MessageBox.Show("Bạn chưa nhập từ ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTuNgay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateDenNgay.Text))
            {
                MessageBox.Show("Bạn chưa nhập đến ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateDenNgay.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateTuGio.Text))
            {
                MessageBox.Show("Bạn chưa nhập từ giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTuGio.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(dateDenGio.Text))
            {
                MessageBox.Show("Bạn chưa nhập đến giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateDenGio.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboNgDangKy.Text))
            {
                MessageBox.Show("Bạn chưa nhập người đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboNgDangKy.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLyDo.Text))
            {
                MessageBox.Show("Bạn chưa nhập lý do!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLyDo.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                DTODangKy dk = new DTODangKy();
                dk.TUNGAY = dateTuNgay.Value;
                dk.DENNGAY = dateDenNgay.Value;
                dk.TUGIO = Convert.ToString(dateTuGio.Text);
                dk.DENGIO = Convert.ToString(dateDenGio.Text);
                dk.NGUOIDANGKY = cboNgDangKy.Text;
                dk.LYDO = txtLyDo.Text;

                if (bllDK.InsertDangKy(dk))
                    ShowAllDangKy();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dtgDangKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dtgDangKy.Rows[index].Cells["colID"].Value.ToString());
                dateTuNgay.Value = DateTime.Parse(dtgDangKy.Rows[index].Cells["colTUNGAY"].Value.ToString());
                dateDenNgay.Value = DateTime.Parse(dtgDangKy.Rows[index].Cells["coLDENNGAY"].Value.ToString());
                dateTuGio.Value = DateTime.Parse(dtgDangKy.Rows[index].Cells["coLTUGIO"].Value.ToString());
                dateDenGio.Value = DateTime.Parse(dtgDangKy.Rows[index].Cells["coLDENGIO"].Value.ToString());
                cboNgDangKy.Text = dtgDangKy.Rows[index].Cells["colNGUOIDANGKY"].Value.ToString();
                txtLyDo.Text = dtgDangKy.Rows[index].Cells["colLYDO"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dk.ID.ToString());
            if (CheckData())
            {
                DTODangKy dk = new DTODangKy();
                dk.ID = ID;
                dk.TUNGAY = dateTuNgay.Value;
                dk.DENNGAY = dateDenNgay.Value;
                dk.TUGIO = Convert.ToString(dateTuGio.Text);
                dk.DENGIO = Convert.ToString(dateDenGio.Text);
                dk.NGUOIDANGKY = cboNgDangKy.Text;
                dk.LYDO = txtLyDo.Text;

                if (bllDK.UpdateDangKy(dk))
                    ShowAllDangKy();
                else
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá học sinh này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DTODangKy dk = new DTODangKy();
                dk.ID = ID;
                if (bllDK.DeleteDangKy(dk))
                    ShowAllDangKy();
                else
                    MessageBox.Show("Đã có lỗi xảy ra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string value = txtTimKiem.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllDK.TimKiem(value);
                dtgDangKy.DataSource = dt;
            }
            else
                ShowAllDangKy();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReport rp = new frmReport();
            rp.ShowDialog();
        }
    }
}
