using BLL;
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
    public partial class fKhoa : Form
    {
        KhoaBLL bLL= new KhoaBLL();
        public fKhoa()
        {
            InitializeComponent();
        }

        private void fKhoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= bLL.GetKhoa();
        }
    }
}
