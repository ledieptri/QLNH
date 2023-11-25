
namespace CK_QLNH
{
    partial class MainNhanVien
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
            this.panelBien = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelIDNV = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonThemNV = new System.Windows.Forms.Button();
            this.buttonPhanCong = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBien.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBien
            // 
            this.panelBien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.panelBien.Controls.Add(this.labelDate);
            this.panelBien.Controls.Add(this.labelTime);
            this.panelBien.Controls.Add(this.labelIDNV);
            this.panelBien.Location = new System.Drawing.Point(340, 1);
            this.panelBien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBien.Name = "panelBien";
            this.panelBien.Size = new System.Drawing.Size(1487, 166);
            this.panelBien.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(1070, 96);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 32);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1070, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(98, 32);
            this.labelTime.TabIndex = 23;
            this.labelTime.Text = "label1";
            // 
            // labelIDNV
            // 
            this.labelIDNV.AutoSize = true;
            this.labelIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelIDNV.Location = new System.Drawing.Point(172, 60);
            this.labelIDNV.Name = "labelIDNV";
            this.labelIDNV.Size = new System.Drawing.Size(132, 46);
            this.labelIDNV.TabIndex = 22;
            this.labelIDNV.Text = "label2";
            // 
            // panelShow
            // 
            this.panelShow.BackColor = System.Drawing.Color.White;
            this.panelShow.Location = new System.Drawing.Point(340, 171);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1487, 655);
            this.panelShow.TabIndex = 7;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.panelButton.Controls.Add(this.buttonThemNV);
            this.panelButton.Controls.Add(this.buttonPhanCong);
            this.panelButton.Controls.Add(this.buttonCancel);
            this.panelButton.Location = new System.Drawing.Point(6, 165);
            this.panelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(328, 661);
            this.panelButton.TabIndex = 4;
            // 
            // buttonThemNV
            // 
            this.buttonThemNV.BackColor = System.Drawing.Color.White;
            this.buttonThemNV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemNV.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemNV.Image = global::CK_QLNH.Properties.Resources._1231;
            this.buttonThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonThemNV.Location = new System.Drawing.Point(6, 8);
            this.buttonThemNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThemNV.Name = "buttonThemNV";
            this.buttonThemNV.Size = new System.Drawing.Size(316, 91);
            this.buttonThemNV.TabIndex = 15;
            this.buttonThemNV.Text = "Thông Tin\r\nNhân Viên";
            this.buttonThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonThemNV.UseVisualStyleBackColor = false;
            this.buttonThemNV.Click += new System.EventHandler(this.buttonTTNV_Click);
            // 
            // buttonPhanCong
            // 
            this.buttonPhanCong.BackColor = System.Drawing.Color.White;
            this.buttonPhanCong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhanCong.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhanCong.Image = global::CK_QLNH.Properties.Resources._804_8048714_we_adopt_a_fair_approach_to_product_pricing1;
            this.buttonPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPhanCong.Location = new System.Drawing.Point(5, 107);
            this.buttonPhanCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPhanCong.Name = "buttonPhanCong";
            this.buttonPhanCong.Size = new System.Drawing.Size(316, 86);
            this.buttonPhanCong.TabIndex = 17;
            this.buttonPhanCong.Text = "Oder Cho Khách";
            this.buttonPhanCong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPhanCong.UseVisualStyleBackColor = false;
            this.buttonPhanCong.Click += new System.EventHandler(this.buttonOder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Image = global::CK_QLNH.Properties.Resources.User_Interface_Logout_icon;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(4, 202);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(316, 86);
            this.buttonCancel.TabIndex = 64;
            this.buttonCancel.Text = "LogOut";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.pictureBox1.BackgroundImage = global::CK_QLNH.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 162);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // MainNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1833, 830);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBien);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelShow);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainNhanVien";
            this.Load += new System.EventHandler(this.MainNhanVien_Load);
            this.panelBien.ResumeLayout(false);
            this.panelBien.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBien;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonThemNV;
        private System.Windows.Forms.Button buttonPhanCong;
        private System.Windows.Forms.Panel panelShow;
        public System.Windows.Forms.Label labelIDNV;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
    }
}