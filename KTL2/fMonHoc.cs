using BLL;
using DAL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTL2
{
    public partial class fMonHoc : Form
    {
        MonHocBLL da;
        public fMonHoc()
        {
            InitializeComponent();
            da= new MonHocBLL();
        }

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            loadGvMonHoc();
        }
        void loadGvMonHoc()
        {
            gvMonHoc.DataSource = da.GetAll();
            gvMonHoc.Columns[0].HeaderText = "Mã môn học";
            gvMonHoc.Columns[1].HeaderText = "Tên môn học";
        }
        private void gvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if(gvMonHoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gvMonHoc.SelectedRows[0];
                string MaMonHoc = selectedRow.Cells[0].Value.ToString();
                string TenMonHoc = selectedRow.Cells[1].Value.ToString();
                txtMaMonHoc.Text= MaMonHoc;
                txtTenMonHoc.Text= TenMonHoc;
            }
        }

        private void tsThem_Click(object sender, EventArgs e)
        {
            if (GetMonHocByText()==null)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu nhập vào", "Thông báo");
                return;
            }
            da.Insert(GetMonHocByText());
            loadGvMonHoc();
        }
        private MonHoc GetMonHocByText()
        {
            string MaMonHoc = txtMaMonHoc.Text;
            string TenMonHoc = txtTenMonHoc.Text;
            if (string.IsNullOrEmpty(MaMonHoc) && string.IsNullOrEmpty(TenMonHoc))
            {
                return null;
            }
            MonHoc monHoc=new MonHoc();
            monHoc.MaMonHoc = MaMonHoc;
            monHoc.TenMonHoc = TenMonHoc;
            return monHoc;
        }
        private void tsXoa_Click(object sender, EventArgs e)
        {
            if (GetMonHocByText() == null)
            {
                MessageBox.Show("Vui lòng chọn môn để xóa", "Thông báo");
                return;
            }
            da.Delete(GetMonHocByText());
            loadGvMonHoc();
        }

        private void tsSua_Click(object sender, EventArgs e)
        {
            if (GetMonHocByText() == null)
            {
                MessageBox.Show("Vui lòng chọn môn để update", "Thông báo");
                return;
            }
            da.Update(GetMonHocByText());
            loadGvMonHoc();

        }
    }
}
