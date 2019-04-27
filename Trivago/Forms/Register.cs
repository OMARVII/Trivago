using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Trivago.Forms
{
    public partial class Register : Form
    {
        OracleConnection conn;
        string connST = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        public Register()
        {
            conn = new OracleConnection(connST);

            conn.Open();
            InitializeComponent();
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }
      bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        Boolean validate()
        {
            if (email.Text=="" || first.Text == ""|| last.Text == ""|| mobile.Text == ""|| password.Text == "")
            {
                MessageBox.Show("Enter Missing Data");
                return true;
            }
           if (mobile.Text.ToString().Length != 11)
            {
                MessageBox.Show("Enter Valid Mobile Number");
                return true;

            }
            if (password.Text.ToString().Length < 6)
            {
                MessageBox.Show("Password must contain at least 6 characters");
                return true;

            }
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Enter Valid E-mail");
                return true;
            }
            return false;


        }
        Boolean check()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Email, Mobile from Users where Email=:email or Mobile=:mobile";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email.Text);
            cmd.Parameters.Add("mobile", mobile.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            
                if (dr.Read())
            {
                MessageBox.Show("Account already exists");
                return true;
            }
            return false;
        }
        private int getuserID()
        {
            int userID;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "generateuserID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            userID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
            userID += 1;
            return userID;
        }
        private void registerr_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                return;
            }
            if (validate() == true)
            {
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into users( id,email, gender, date_of_birth, first_name, last_name, mobile, password, is_admin) values(:id,:email,:gender,:dateofbirth, :firstname, :lastname, :mobile, :password,'f') ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", getuserID());
            cmd.Parameters.Add("email", email.Text);
            if (f.Checked)
                cmd.Parameters.Add("gender", 'f');
            else
                cmd.Parameters.Add("gender", 'm');
            cmd.Parameters.Add("dateofbirth", dateofbirth.Value);
            cmd.Parameters.Add("firstname", first.Text);
            cmd.Parameters.Add("lastname", last.Text);
            cmd.Parameters.Add("mobile", mobile.Text);
            cmd.Parameters.Add("password", password.Text);

            int r = cmd.ExecuteNonQuery();
            if (r>0)
            {
                MessageBox.Show("Registeration Completed!");
            }
          
        }
    }
}
