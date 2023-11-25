
namespace CK_QLNH
{
    partial class MainQuanLy
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
            this.components = new System.ComponentModel.Container();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelBien = new System.Windows.Forms.Panel();
            this.labelIDNV = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonQuanLyNV = new System.Windows.Forms.Button();
            this.buttonQLMon = new System.Windows.Forms.Button();
            this.buttonQLBan = new System.Windows.Forms.Button();
            this.panelButton.SuspendLayout();
            this.panelBien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panelButton.Controls.Add(this.buttonCancel);
            this.panelButton.Controls.Add(this.buttonThongKe);
            this.panelButton.Controls.Add(this.buttonQuanLyNV);
            this.panelButton.Controls.Add(this.buttonQLMon);
            this.panelButton.Controls.Add(this.buttonQLBan);
            this.panelButton.Location = new System.Drawing.Point(0, 184);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(331, 785);
            this.panelButton.TabIndex = 0;
            // 
            // panelBien
            // 
            this.panelBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panelBien.Controls.Add(this.labelIDNV);
            this.panelBien.Controls.Add(this.labelDate);
            this.panelBien.Controls.Add(this.labelTime);
            this.panelBien.Location = new System.Drawing.Point(336, 10);
            this.panelBien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBien.Name = "panelBien";
            this.panelBien.Size = new System.Drawing.Size(1538, 166);
            this.panelBien.TabIndex = 1;
            // 
            // labelIDNV
            // 
            this.labelIDNV.AutoSize = true;
            this.labelIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelIDNV.Location = new System.Drawing.Point(336, 48);
            this.labelIDNV.Name = "labelIDNV";
            this.labelIDNV.Size = new System.Drawing.Size(501, 52);
            this.labelIDNV.TabIndex = 23;
            this.labelIDNV.Text = "Xin Chào Bạn Quản Lý";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(1110, 111);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 32);
            this.labelDate.TabIndex = 68;
            this.labelDate.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1109, 48);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 32);
            this.labelTime.TabIndex = 67;
            this.labelTime.Text = "label1";
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.White;
            this.panelShow.Location = new System.Drawing.Point(338, 184);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1537, 791);
            this.panelShow.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.BackgroundImage = global::CK_QLNH.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 162);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::CK_QLNH.Properties.Resources.User_Interface_Logout_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(14, 404);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(316, 86);
            this.buttonCancel.TabIndex = 65;
            this.buttonCancel.Text = "LogOut";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.BackColor = System.Drawing.Color.White;
            this.buttonThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.Image = global::CK_QLNH.Properties.Resources.Bar_Chart_icon;
            this.buttonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThongKe.Location = new System.Drawing.Point(14, 304);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(316, 91);
            this.buttonThongKe.TabIndex = 21;
            this.buttonThongKe.Text = "Thống Kê\r\nDoanh Thu";
            this.buttonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonQuanLyNV
            // 
            this.buttonQuanLyNV.BackColor = System.Drawing.Color.White;
            this.buttonQuanLyNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyNV.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyNV.Image = global::CK_QLNH.Properties.Resources.cf44e50128fcdda284ed;
            this.buttonQuanLyNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQuanLyNV.Location = new System.Drawing.Point(14, 0);
            this.buttonQuanLyNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQuanLyNV.Name = "buttonQuanLyNV";
            this.buttonQuanLyNV.Size = new System.Drawing.Size(316, 99);
            this.buttonQuanLyNV.TabIndex = 18;
            this.buttonQuanLyNV.Text = "Quản Lý \r\nNhân Viên";
            this.buttonQuanLyNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuanLyNV.UseVisualStyleBackColor = false;
            this.buttonQuanLyNV.Click += new System.EventHandler(this.buttonQuanLyNV_Click);
            // 
            // buttonQLMon
            // 
            this.buttonQLMon.BackColor = System.Drawing.Color.White;
            this.buttonQLMon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonQLMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLMon.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLMon.Image = global::CK_QLNH.Properties.Resources._57735439_food_sign_icon_cutlery_symbol_knife_and_fork_gray_circle_button_with_icon_vector1;
            this.buttonQLMon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQLMon.Location = new System.Drawing.Point(14, 205);
            this.buttonQLMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQLMon.Name = "buttonQLMon";
            this.buttonQLMon.Size = new System.Drawing.Size(316, 91);
            this.buttonQLMon.TabIndex = 20;
            this.buttonQLMon.Text = "Quản Lý \r\nMón Ăn";
            this.buttonQLMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQLMon.UseVisualStyleBackColor = false;
            this.buttonQLMon.Click += new System.EventHandler(this.buttonQLMon_Click);
            // 
            // buttonQLBan
            // 
            this.buttonQLBan.BackColor = System.Drawing.Color.White;
            this.buttonQLBan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonQLBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLBan.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLBan.Image = global::CK_QLNH.Properties.Resources._11518201;
            this.buttonQLBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonQLBan.Location = new System.Drawing.Point(14, 106);
            this.buttonQLBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonQLBan.Name = "buttonQLBan";
            this.buttonQLBan.Size = new System.Drawing.Size(316, 91);
            this.buttonQLBan.TabIndex = 19;
            this.buttonQLBan.Text = "Quản Lý \r\nBàn Ăn";
            this.buttonQLBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQLBan.UseVisualStyleBackColor = false;
            this.buttonQLBan.Click += new System.EventHandler(this.buttonQLBan_Click);
            // 
            // MainQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1874, 984);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelBien);
            this.Controls.Add(this.panelButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainQuanLy";
            this.Load += new System.EventHandler(this.MainQuanLy_Load);
            this.panelButton.ResumeLayout(false);
            this.panelBien.ResumeLayout(false);
            this.panelBien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelBien;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Button buttonQLMon;
        private System.Windows.Forms.Button buttonQLBan;
        private System.Windows.Forms.Button buttonQuanLyNV;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelIDNV;
    }
}