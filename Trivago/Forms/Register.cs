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
using System.Runtime.InteropServices;

namespace Trivago.Forms
{
    public partial class Register : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        OracleConnection conn;
        string connST = "Data Source=orcl;User Id=HR;Password=HR;";
        public Register()
        {
            conn = new OracleConnection(connST);

            conn.Open();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
            if (checkb.Checked==false)
            {
                MessageBox.Show("You must agree on terms and conditions!");
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
            try
            {
                userID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                userID += 1;
            }
            catch 
            {

                userID = 1;
            }
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

        private void mobile_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        
        private void bunifuLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void first_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void last_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void email_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void m_Click(object sender, EventArgs e)
        {

        }

        private void f_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

            Agreement a = new Agreement();
            a.Show();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            if (checkb.Checked)
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
                if (r > 0)
                {
                    MessageBox.Show("Registeration Completed!");
                }
            }
            else
                MessageBox.Show("You must agree on terms and conditions!");
        
    }

        private void haveaccount_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
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
                if (r > 0)
                {
                    MessageBox.Show("Registeration Completed!");
                
            }
            
                
        }
    }
}
