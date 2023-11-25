
namespace CK_QLNH
{
    partial class ThemNVForm
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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.PictureBoxNV = new System.Windows.Forms.PictureBox();
            this.DateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddr = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.textBoxGmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.BackColor = System.Drawing.Color.White;
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.ForeColor = System.Drawing.Color.Silver;
            this.textBoxFName.Location = new System.Drawing.Point(71, 117);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(230, 30);
            this.textBoxFName.TabIndex = 1;
            this.textBoxFName.Enter += new System.EventHandler(this.textBoxFName_Enter);
            this.textBoxFName.Leave += new System.EventHandler(this.textBoxFName_Leave);
            // 
            // textBoxLName
            // 
            this.textBoxLName.BackColor = System.Drawing.Color.White;
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.ForeColor = System.Drawing.Color.Black;
            this.textBoxLName.Location = new System.Drawing.Point(71, 170);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(230, 30);
            this.textBoxLName.TabIndex = 2;
            this.textBoxLName.Enter += new System.EventHandler(this.textBoxLName_Enter);
            this.textBoxLName.Leave += new System.EventHandler(this.textBoxLName_Leave);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.White;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.Black;
            this.textBoxUserName.Location = new System.Drawing.Point(346, 117);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(218, 30);
            this.textBoxUserName.TabIndex = 10;
            this.textBoxUserName.Enter += new System.EventHandler(this.textBoxUserName_Enter);
            this.textBoxUserName.Leave += new System.EventHandler(this.textBoxUserName_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(346, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(218, 30);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Image = global::CK_QLNH.Properties.Resources.Add_Folder_icon;
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreate.Location = new System.Drawing.Point(212, 34);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(230, 35);
            this.buttonCreate.TabIndex = 155;
            this.buttonCreate.Text = "Thêm Nhân Viên";
            this.buttonCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ButtonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUploadImage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUploadImage.ForeColor = System.Drawing.Color.White;
            this.ButtonUploadImage.Image = global::CK_QLNH.Properties.Resources.Upload_Folder_icon;
            this.ButtonUploadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonUploadImage.Location = new System.Drawing.Point(346, 410);
            this.ButtonUploadImage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(218, 36);
            this.ButtonUploadImage.TabIndex = 12;
            this.ButtonUploadImage.Text = "Upload Image";
            this.ButtonUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonUploadImage.UseVisualStyleBackColor = false;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // PictureBoxNV
            // 
            this.PictureBoxNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PictureBoxNV.Location = new System.Drawing.Point(346, 218);
            this.PictureBoxNV.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxNV.Name = "PictureBoxNV";
            this.PictureBoxNV.Size = new System.Drawing.Size(218, 174);
            this.PictureBoxNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxNV.TabIndex = 159;
            this.PictureBoxNV.TabStop = false;
            // 
            // DateTimePickerBirth
            // 
            this.DateTimePickerBirth.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirth.Location = new System.Drawing.Point(71, 222);
            this.DateTimePickerBirth.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerBirth.Name = "DateTimePickerBirth";
            this.DateTimePickerBirth.Size = new System.Drawing.Size(230, 29);
            this.DateTimePickerBirth.TabIndex = 3;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(71, 274);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(66, 24);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(212, 274);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(85, 24);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.Black;
            this.textBoxPhone.Location = new System.Drawing.Point(71, 318);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(230, 30);
            this.textBoxPhone.TabIndex = 6;
            this.textBoxPhone.Enter += new System.EventHandler(this.textBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // textBoxAddr
            // 
            this.textBoxAddr.BackColor = System.Drawing.Color.White;
            this.textBoxAddr.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddr.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddr.Location = new System.Drawing.Point(71, 375);
            this.textBoxAddr.Name = "textBoxAddr";
            this.textBoxAddr.Size = new System.Drawing.Size(230, 30);
            this.textBoxAddr.TabIndex = 7;
            this.textBoxAddr.Enter += new System.EventHandler(this.textBoxAddr_Enter);
            this.textBoxAddr.Leave += new System.EventHandler(this.textBoxAddr_Leave);
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.BackColor = System.Drawing.Color.White;
            this.textBoxCMND.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.ForeColor = System.Drawing.Color.Black;
            this.textBoxCMND.Location = new System.Drawing.Point(71, 428);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(230, 30);
            this.textBoxCMND.TabIndex = 8;
            this.textBoxCMND.Enter += new System.EventHandler(this.textBoxCMND_Enter);
            this.textBoxCMND.Leave += new System.EventHandler(this.textBoxCMND_Leave);
            // 
            // textBoxGmail
            // 
            this.textBoxGmail.BackColor = System.Drawing.Color.White;
            this.textBoxGmail.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGmail.ForeColor = System.Drawing.Color.Black;
            this.textBoxGmail.Location = new System.Drawing.Point(71, 482);
            this.textBoxGmail.Name = "textBoxGmail";
            this.textBoxGmail.Size = new System.Drawing.Size(230, 30);
            this.textBoxGmail.TabIndex = 9;
            this.textBoxGmail.Enter += new System.EventHandler(this.textBoxGmail_Enter);
            this.textBoxGmail.Leave += new System.EventHandler(this.textBoxGmail_Leave);
            // 
            // ThemNVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 539);
            this.Controls.Add(this.textBoxGmail);
            this.Controls.Add(this.textBoxCMND);
            this.Controls.Add(this.textBoxAddr);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxNV);
            this.Controls.Add(this.DateTimePickerBirth);
            this.Controls.Add(this.textBoxFName);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "ThemNVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNVForm";
            this.Load += new System.EventHandler(this.ThemNVForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.Button ButtonUploadImage;
        public System.Windows.Forms.PictureBox PictureBoxNV;
        public System.Windows.Forms.DateTimePicker DateTimePickerBirth;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddr;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.TextBox textBoxGmail;
    }
}