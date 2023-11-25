using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CK_QLNH
{
    class NhanVien
    {
        DataBase myDb = new DataBase();
        
        public DataTable getNhanVien(SqlCommand command)
        {
            command.Connection = myDb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteChiaCa(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM ChiaCa WHERE Id = @id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool deleteLuongNV(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LuongNV WHERE Id = @id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool deleteTimeLV(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM TimeLamViec WHERE Id = @id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool updateNhanVien(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture, string cmnd, string gmail)
        {
            SqlCommand command = new SqlCommand("UPDATE ListNV_ SET TenNV=@fn, HoNV=@ln, NgaySinhNV=@bdt, GioiTinhNV=@ge, SDTNV=@pho,DIACHINV=@add, CMND=@cmnd, Gmail=@gmail, HinhNV=@pic WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@ge", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pho", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;

            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool updatePassWord(int Id, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE NhanVien SET PassWord=@pass WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool updateCaLam(int Id, int Thu2, int Thu3, int Thu4, int Thu5, int Thu6, int Thu7, int CN)
        {
            SqlCommand command = new SqlCommand("UPDATE ChiaCa SET Thu2=@t2, Thu3=@t3, Thu4=@t4, Thu5=@t5, Thu6=@t6, Thu7=@t7, CN=@cn WHERE Id=@Id", myDb.GetConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@t2", SqlDbType.Int).Value = Thu2;
            command.Parameters.Add("@t3", SqlDbType.Int).Value = Thu3;
            command.Parameters.Add("@t4", SqlDbType.Int).Value = Thu4;
            command.Parameters.Add("@t5", SqlDbType.Int).Value = Thu5;
            command.Parameters.Add("@t6", SqlDbType.Int).Value = Thu6;
            command.Parameters.Add("@t7", SqlDbType.Int).Value = Thu7;
            command.Parameters.Add("@cn", SqlDbType.Int).Value = CN;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }

        public bool deleteNhanVien(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM ListNV_ WHERE Id = @id", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool insertNhanVien(int Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, string cmnd, string gmail, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO ListNV_(Id, HoNV, TenNV, NgaySinhNV, GioiTinhNV, DiaChiNV, SDTNV, CMND, Gmail, HinhNV)" +
                "VALUES (@id, @fn, @ln, @bdt, @ge, @add, @pho, @cmnd, @gmail, @pic)", myDb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@ge", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@pho", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            myDb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                myDb.closeConnection();
                return true;
            }
            else
            {
                myDb.closeConnection();
                return false;
            }
        }
        public bool checkStaffId(int courseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM ListNV_ WHERE Id=@cId", myDb.GetConnection);
            command.Parameters.Add("@cId", SqlDbType.VarChar).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
