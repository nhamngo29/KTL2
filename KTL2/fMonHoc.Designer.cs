namespace KTL2
{
    partial class fMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSua = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDong = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvMonHoc = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThem,
            this.tsXoa,
            this.tsSua,
            this.tsDong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsThem
            // 
            this.tsThem.Name = "tsThem";
            this.tsThem.Size = new System.Drawing.Size(49, 20);
            this.tsThem.Text = "Thêm";
            this.tsThem.Click += new System.EventHandler(this.tsThem_Click);
            // 
            // tsXoa
            // 
            this.tsXoa.Name = "tsXoa";
            this.tsXoa.Size = new System.Drawing.Size(39, 20);
            this.tsXoa.Text = "Xóa";
            this.tsXoa.Click += new System.EventHandler(this.tsXoa_Click);
            // 
            // tsSua
            // 
            this.tsSua.Name = "tsSua";
            this.tsSua.Size = new System.Drawing.Size(38, 20);
            this.tsSua.Text = "Sửa";
            this.tsSua.Click += new System.EventHandler(this.tsSua_Click);
            // 
            // tsDong
            // 
            this.tsDong.Name = "tsDong";
            this.tsDong.Size = new System.Drawing.Size(48, 20);
            this.tsDong.Text = "Đóng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Môn Học";
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(217, 39);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(253, 20);
            this.txtMaMonHoc.TabIndex = 2;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(217, 74);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(253, 20);
            this.txtTenMonHoc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Môn Học";
            // 
            // gvMonHoc
            // 
            this.gvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMonHoc.Location = new System.Drawing.Point(0, 123);
            this.gvMonHoc.MultiSelect = false;
            this.gvMonHoc.Name = "gvMonHoc";
            this.gvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMonHoc.Size = new System.Drawing.Size(636, 327);
            this.gvMonHoc.TabIndex = 5;
            this.gvMonHoc.SelectionChanged += new System.EventHandler(this.gvMonHoc_SelectionChanged);
            // 
            // fMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.gvMonHoc);
            this.Controls.Add(this.txtTenMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMonHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMonHoc";
            this.Text = "fMonHoc";
            this.Load += new System.EventHandler(this.fMonHoc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsThem;
        private System.Windows.Forms.ToolStripMenuItem tsXoa;
        private System.Windows.Forms.ToolStripMenuItem tsSua;
        private System.Windows.Forms.ToolStripMenuItem tsDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvMonHoc;
    }
}