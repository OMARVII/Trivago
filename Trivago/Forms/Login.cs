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
    public partial class Login : Form
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
        public static string userID = "1";
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=HR;";
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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
            {
                MessageBox.Show("wooow You have Logged in");
                userID = rd["id"].ToString();
            }
            else
                MessageBox.Show("Nooo wrong wrong wrong");
            AddWebsite temp = new AddWebsite();
            this.Hide();
            temp.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }
    }
}
