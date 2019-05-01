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
    public partial class AccountSettings : Form
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
        string connST = "Data Source=ORCL;User Id=HR;Password=hr;";
        public AccountSettings()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            loadUser();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }
        void loadUser()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users where id=:loggedID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("loggedID", Login.userID);
            OracleDataReader dr = cmd.ExecuteReader();
            string gender;
            string dateBirth;
            if (dr.Read())
            {
                first.Text = dr["first_name"].ToString();
                last.Text = dr["last_name"].ToString();
                email.Text = dr["email"].ToString();
                password.Text = dr["password"].ToString();
                mobile.Text = dr["mobile"].ToString();
                gender = dr["gender"].ToString();
                dateBirth = dr["date_of_birth"].ToString();
                dateofbirth.Value = DateTime.Parse(dateBirth);
                if (gender == "m")
                {
                    m.Checked = true;
                    f.Checked = false;
                }
                else { f.Checked = true; m.Checked = false;
                    
                }

                bunifuLabel2.Text = "Welcome " + first.Text+"!";
            }
            dr.Close();
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
            if (email.Text == "" || first.Text == "" || last.Text == "" || mobile.Text == "" || password.Text == "")
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
                MessageBox.Show("Email/Mobile already exists");
                return true;
            }
            return false;
        }
        void update()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update users set first_name=:nfirstname, last_name=:nlastname, email=:nemail, mobile=:nmobile, password=:npassword, gender=:ngender, date_of_birth=:ndateofbirth where id=:userid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("nfirstname", first.Text);
            cmd.Parameters.Add("nlastname", last.Text);
            cmd.Parameters.Add("nemail", email.Text);
            cmd.Parameters.Add("nmobile", mobile.Text);
            cmd.Parameters.Add("npassword", password.Text);
            if (f.Checked)
                cmd.Parameters.Add("gender", 'f');
            else
                cmd.Parameters.Add("gender", 'm');
            cmd.Parameters.Add("ndateofbirth", dateofbirth.Value);
            cmd.Parameters.Add("userid", Login.userID);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Updated Successfully!");
                loadUser();
            }
            else MessageBox.Show("Something Wrong!");
        }
        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (check()) return;
            if (validate()) return;
            update();
        }

        private void dateofbirth_onValueChanged(object sender, EventArgs e)
        {

        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
