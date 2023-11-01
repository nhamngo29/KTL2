using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTL2
{
    public partial class fSinhVien : Form
    {
        SinhVienBLL sv;
        LopBLL l;
        public fSinhVien()
        {
            InitializeComponent();
            sv=new SinhVienBLL();
            l=new LopBLL();
        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
            loadGV();
        }
        void loadGV()
        {
            gvSinhVien.DataSource= sv.GetAllSV();
            gvSinhVien.Columns["TenLop"].HeaderText = "Tên Lớp";
            loadCbLop();
        }
        void loadCbLop()
        {
            cboMaLop.DataSource = l.GetAll();
            cboMaLop.DisplayMember= "TenLop";
            cboMaLop.ValueMember = "MaLop";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (gvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvSinhVien.SelectedRows[0];
                string MaSSV= selectedRow.Cells[0].Value.ToString();
                string HoTen= selectedRow.Cells[1].Value.ToString();
                DateTime NgaySinh = DateTime.Parse(selectedRow.Cells[2].Value.ToString());
                string MaLop= selectedRow.Cells[3].Value.ToString()??"123";
                txtMsv.Text= MaSSV;
                txtMsv.Text= HoTen;
                int index = cboMaLop.FindString(MaLop);
                if (index != -1)
                {
                    cboMaLop.SelectedIndex = index;
                }
            }
        }
    }
}
