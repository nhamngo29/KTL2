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

namespace KTL2
{
    public partial class fQuanLyDiem : Form
    {
        KhoaBLL khoa;
        LopBLL lop;
        SinhVienBLL sv;
        MonHocBLL mh;
        DiemBLL diem;
        public fQuanLyDiem()
        {
            InitializeComponent();
            khoa= new KhoaBLL();
            lop= new LopBLL();
            sv= new SinhVienBLL();
            mh= new MonHocBLL();
            diem= new DiemBLL();
        }

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            cboKhoa();
            Load_cboMonHoc();


        }
        void Load_cboMonHoc()
        {
            cboMonHoc.DataSource = mh.GetAll();
            cboMonHoc.DisplayMember = "TenMonHoc";
            cboMonHoc.ValueMember= "MaMonHoc";
        }    
        void cboKhoa()
        {
            cboKhoaa.DataSource = khoa.GetKhoa();
            cboKhoaa.DisplayMember= "TenKhoa";
            cboKhoaa.ValueMember = "MaKhoa";
        }
        void Load_cboLop(string MaKhoa)
        {
            cboLop.DataSource = lop.GetLopByIdKhoa(MaKhoa);
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }
        void Load_gvSinhVien(string id)
        {
            gv_SV.DataSource=sv.GétinhVienByIdLop(id);
        }
        private void cboKhoaa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_cboLop(cboKhoaa.SelectedValue.ToString());
        }
        void Load_GVDiem()
        {
            gv_diem.DataSource = diem.GetAll();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_gvSinhVien(cboLop.SelectedValue.ToString());
        }

        private void gv_SV_SelectionChanged(object sender, EventArgs e)
        {
            if (gv_SV.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gv_SV.SelectedRows[0];
                string MaSSV = selectedRow.Cells[0].Value.ToString();
                txtMaSinhVien.Text=MaSSV;
            }
        }

        private void gv_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaMH=cboMonHoc.SelectedValue.ToString();
            string MaSV = txtMaSinhVien.Text;
            float Diem = float.TryParse(txtDiem.Text, out float parsedValue) ? parsedValue : 0;
            if(MaMH!=null&&MaSV!=null)
            {
                Diem d = new Diem();
                d.MaMonHoc= MaMH;
                d.MaSinhVien= MaSV;
                d.Diem1 = Diem;
                diem.Insert(d);
                Load_GVDiem();
            } 
        }
    }
}
