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
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=HR;";
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
            string cmdst = "select * from Users where EMAIL=:email AND PASSWORD=:password";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmdst;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", EmailTxtBox.Text);
            cmd.Parameters.Add("password", PasswordTxtBox.Text);
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                MessageBox.Show("wooow You have Logged in" );
            else
                MessageBox.Show("Nooo wrong wrong wrong");
            
        }
    }
}
