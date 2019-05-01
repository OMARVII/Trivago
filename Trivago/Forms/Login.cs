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
    public partial class Login : Form
    {
        public static string userID = "1";
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=ALAAalaa21;";
        public Login()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string cmdst = "select * from Users where EMAIL=:email AND PASSWORD=:password ";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdst;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", EmailTxtBox.Text);
            cmd.Parameters.Add("password", PasswordTxtBox.Text);
            OracleDataReader rd = cmd.ExecuteReader();

           
            
                if (rd.Read())
                {
                
                    MessageBox.Show(" You Have Logged In Successfully");
                    userID = rd["id"].ToString();
                if (rd["is_admin"].ToString() == "t")
                {
                    conn.Close();
                    Admin temp = new Admin();
                    this.Hide();
                    temp.ShowDialog();
                    this.Close();
                }
                else
                {
                    conn.Close();
                    ReserveRoom temp = new ReserveRoom();
                    this.Hide();
                    temp.ShowDialog();
                    this.Close();
                }
        
                }
                else
                    MessageBox.Show("Wrong email or password");
            

          



        

    }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
