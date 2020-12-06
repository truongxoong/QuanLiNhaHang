
namespace QuanLiNhaHang
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinCaNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButThemMon = new System.Windows.Forms.Button();
            this.cobHienThiMonAn = new System.Windows.Forms.ComboBox();
            this.cobDanhSachMA = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 360);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thongTinTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            this.thongTinTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhanToolStripMenuItem,
            this.dangXuatToolStripMenuItem});
            this.thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            this.thongTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.thongTinTaiKhoanToolStripMenuItem.Text = "Thong Tin Tai Khoan";
            this.thongTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thongTinTaiKhoanToolStripMenuItem_Click);
            // 
            // thongTinCaNhanToolStripMenuItem
            // 
            this.thongTinCaNhanToolStripMenuItem.Name = "thongTinCaNhanToolStripMenuItem";
            this.thongTinCaNhanToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.thongTinCaNhanToolStripMenuItem.Text = "Thong Tin Ca Nhan";
            this.thongTinCaNhanToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dangXuatToolStripMenuItem.Text = "Dang Xuat";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(343, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 216);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ButThemMon);
            this.panel3.Controls.Add(this.cobHienThiMonAn);
            this.panel3.Controls.Add(this.cobDanhSachMA);
            this.panel3.Location = new System.Drawing.Point(343, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 74);
            this.panel3.TabIndex = 3;
            // 
            // ButThemMon
            // 
            this.ButThemMon.Location = new System.Drawing.Point(152, 12);
            this.ButThemMon.Name = "ButThemMon";
            this.ButThemMon.Size = new System.Drawing.Size(66, 53);
            this.ButThemMon.TabIndex = 2;
            this.ButThemMon.Text = "Them Mon";
            this.ButThemMon.UseVisualStyleBackColor = true;
            // 
            // cobHienThiMonAn
            // 
            this.cobHienThiMonAn.FormattingEnabled = true;
            this.cobHienThiMonAn.Location = new System.Drawing.Point(16, 50);
            this.cobHienThiMonAn.Name = "cobHienThiMonAn";
            this.cobHienThiMonAn.Size = new System.Drawing.Size(130, 21);
            this.cobHienThiMonAn.TabIndex = 1;
            // 
            // cobDanhSachMA
            // 
            this.cobDanhSachMA.FormattingEnabled = true;
            this.cobDanhSachMA.Location = new System.Drawing.Point(16, 12);
            this.cobDanhSachMA.Name = "cobDanhSachMA";
            this.cobDanhSachMA.Size = new System.Drawing.Size(130, 21);
            this.cobDanhSachMA.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "QuanLiNhaHang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButThemMon;
        private System.Windows.Forms.ComboBox cobHienThiMonAn;
        private System.Windows.Forms.ComboBox cobDanhSachMA;
    }
}