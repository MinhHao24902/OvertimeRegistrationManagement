using Microsoft.Reporting.WinForms;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            DatabaseDangKy DbDangKy = new DatabaseDangKy();
            List<DANGKY> listdangky = DbDangKy.DANGKies.ToList(); //Bên trong database mà mình đã thêm vào
            List<DTODangKy> listreport = new List<DTODangKy>();
            foreach (DANGKY dk in listdangky)
            {
                DTODangKy temp = new DTODangKy(); //DTO (class của đối tượng)
                temp.ID = dk.ID;
                temp.TUNGAY = dk.TUNGAY.Value;
                temp.DENNGAY = dk.DENNGAY.Value;
                temp.TUGIO = dk.TUGIO;
                temp.DENGIO = dk.DENGIO;
                temp.NGUOIDANGKY = dk.NGUOIDANGKY;
                temp.LYDO = dk.LYDO;

                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "./Report/ReportDangKy.rdlc"; //file rdlc Report
            var source = new ReportDataSource("ThongKeDangKy", listreport); // phải đúng tên DataSet (Phân biệt chữ hoa và thường)
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
