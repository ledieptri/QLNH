using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CK_QLNH
{
    public partial class ThemNVForm : Form
    {
        public ThemNVForm()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        IDLamViec idl = new IDLamViec();
        AccountNV tk = new AccountNV();
        NhanVien nv = new NhanVien();
        QuanLyNV_UC ql = new QuanLyNV_UC();
        public static int dem;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try {
                string username = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                string lname = textBoxLName.Text;
                string fname = textBoxFName.Text;
                DateTime bdate = DateTimePickerBirth.Value;
                string gen = "";
                string phone = textBoxPhone.Text;
                string addr = textBoxAddr.Text;
                string cmnd = textBoxCMND.Text;
                string gmail = textBoxGmail.Text;
                MemoryStream picture = new MemoryStream();

                if (radioButtonMale.Checked)
                {
                    gen = "Male";
                }
                else if (radioButtonFemale.Checked)
                {
                    gen = "Female";
                }

                SqlCommand commandCheckUsername = new SqlCommand("SELECT Id, TenNV, HoNV FROM NhanVien WHERE UserName = @username");
                commandCheckUsername.Parameters.Add("@username", SqlDbType.VarChar).Value = textBoxUserName.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                commandCheckUsername.Connection = db.GetConnection;
                adapter.SelectCommand = commandCheckUsername;


                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Username đã tồn tại", "Username Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = count() + 1;

                if (tk.insertAccount(id, username, password, fname, lname))
                {
                    count();
                    idl.insertChiaca(dem, "", "", "", "", "", "", "");
                    idl.insertTime(dem);
                    idl.insertLuong(dem);
                    PictureBoxNV.Image.Save(picture, PictureBoxNV.Image.RawFormat);
                    nv.insertNhanVien(dem, fname, lname, bdate, gen, phone, addr, cmnd, gmail, picture);

                    MessageBox.Show("New Account Add", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch 
            {
                MessageBox.Show("Error", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }

        private int count()
        {
            SqlCommand command = new SqlCommand(" SELECT Id FROM NhanVien", db.GetConnection);
            SqlDataAdapter adapterc = new SqlDataAdapter(command);
            DataTable tablec = new DataTable();
            adapterc.Fill(tablec);
            dem = Convert.ToInt32(tablec.Rows[Convert.ToInt32(tablec.Rows.Count.ToString()) - 1]["Id"].ToString());
            return dem;
        }

        bool verif()
        {
            if ((textBoxUserName.Text.Trim() == "") || (textBoxPassword.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ThemNVForm_Load(object sender, EventArgs e)
        {
            textBoxUserName.ForeColor = Color.Black;
            textBoxUserName.Text = "New UserName";
            textBoxUserName.Leave += new EventHandler(textBoxUserName_Leave);
            textBoxUserName.Enter += new EventHandler(textBoxUserName_Enter);

            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Text = "PassWord";
            textBoxPassword.Leave += new EventHandler(textBoxPassword_Leave);
            textBoxPassword.Enter += new EventHandler(textBoxPassword_Enter);

            textBoxFName.ForeColor = Color.Black;
            textBoxFName.Text = "First Name";
            textBoxFName.Leave += new EventHandler(textBoxFName_Leave);
            textBoxFName.Enter += new EventHandler(textBoxFName_Enter);

            textBoxLName.ForeColor = Color.Black;
            textBoxLName.Text = "Last Name";
            textBoxLName.Leave += new EventHandler(textBoxLName_Leave);
            textBoxLName.Enter += new EventHandler(textBoxLName_Enter);

            textBoxAddr.ForeColor = Color.Black;
            textBoxAddr.Text = "Address";
            textBoxAddr.Leave += new EventHandler(textBoxAddr_Leave);
            textBoxAddr.Enter += new EventHandler(textBoxAddr_Enter);

            textBoxCMND.ForeColor = Color.Black;
            textBoxCMND.Text = "CMND";
            textBoxCMND.Leave += new EventHandler(textBoxCMND_Leave);
            textBoxCMND.Enter += new EventHandler(textBoxCMND_Enter);

            textBoxGmail.ForeColor = Color.Black;
            textBoxGmail.Text = "Gmail";
            textBoxGmail.Leave += new EventHandler(textBoxGmail_Leave);
            textBoxGmail.Enter += new EventHandler(textBoxGmail_Enter);

            textBoxPhone.ForeColor = Color.Black;
            textBoxPhone.Text = "Phone Number";
            textBoxPhone.Leave += new EventHandler(textBoxPhone_Leave);
            textBoxPhone.Enter += new EventHandler(textBoxPhone_Enter);
        }

        private void textBoxFName_Leave(object sender, EventArgs e)
        {
            if (textBoxFName.Text == "")
            {
                textBoxFName.Text = "First Name";
                textBoxFName.ForeColor = Color.Black;
            }
        }

        private void textBoxFName_Enter(object sender, EventArgs e)
        {
            if (textBoxFName.Text == "First Name")
            {
                textBoxFName.Text = "";
                textBoxFName.ForeColor = Color.Black;
            }
        }

        private void textBoxLName_Leave(object sender, EventArgs e)
        {
            if (textBoxLName.Text == "")
            {
                textBoxLName.Text = "Last Name";
                textBoxLName.ForeColor = Color.Black;
            }
        }

        private void textBoxLName_Enter(object sender, EventArgs e)
        {
            if (textBoxLName.Text == "Last Name")
            {
                textBoxLName.Text = "";
                textBoxLName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "")
            {
                textBoxUserName.Text = "New UserName";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "New UserName")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "PassWord";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "PassWord")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PictureBoxNV.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                textBoxPhone.Text = "Phone Number";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "Phone Number")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxAddr_Leave(object sender, EventArgs e)
        {
            if (textBoxAddr.Text == "")
            {
                textBoxAddr.Text = "Address";
                textBoxAddr.ForeColor = Color.Black;
            }
        }

        private void textBoxAddr_Enter(object sender, EventArgs e)
        {
            if (textBoxAddr.Text == "Address")
            {
                textBoxAddr.Text = "";
                textBoxAddr.ForeColor = Color.Black;
            }
        }

        private void textBoxCMND_Leave(object sender, EventArgs e)
        {
            if (textBoxCMND.Text == "")
            {
                textBoxCMND.Text = "CMND";
                textBoxCMND.ForeColor = Color.Black;
            }
        }

        private void textBoxCMND_Enter(object sender, EventArgs e)
        {
            if (textBoxCMND.Text == "CMND")
            {
                textBoxCMND.Text = "";
                textBoxCMND.ForeColor = Color.Black;
            }
        }

        private void textBoxGmail_Leave(object sender, EventArgs e)
        {
            if (textBoxGmail.Text == "")
            {
                textBoxGmail.Text = "Gmail";
                textBoxGmail.ForeColor = Color.Black;
            }
        }

        private void textBoxGmail_Enter(object sender, EventArgs e)
        {
            if (textBoxGmail.Text == "Gmail")
            {
                textBoxGmail.Text = "";
                textBoxGmail.ForeColor = Color.Black;
            }
        }
    }
}
