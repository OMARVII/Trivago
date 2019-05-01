using System;
using System.Collections.Generic;
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
    public partial class DeleteWebsite : Form
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
        string str = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        string deletedID = "";
        public DeleteWebsite()
        {
          
            InitializeComponent();
            conn = new OracleConnection(str);
            conn.Open();
            loadWebsites();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        Boolean validate()
        {
            if (website.SelectedIndex == -1 && deletedID != "")
            {
                MessageBox.Show("already deleted");
                return true;
            }
            if (website.SelectedIndex == -1)
            {
                MessageBox.Show("Choose an id");
                return true;
            }
            return false;
        }
        void delWebsiteInRoom()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Room_In_Website where website_id =:websiteid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("websiteid", website.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
        }
        void loadWebsites()
        {
            website.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from website ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                website.Items.Add(dr[0]);                
            }
            
            dr.Close();



        }
        private void website_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from website where id=:websiteid ";
            cmd.Parameters.Add("websitid",website.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                websiteN.Text = dr["name"].ToString();
            }
            

        }


        private void websiteN_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteWebsite_Load(object sender, EventArgs e)
        {

        }
        void updateBTN_Click()
        {

        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (validate()) return;
            delWebsiteInRoom();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from website where id=:websiteid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("websiteid", website.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Website is successfully deleted !");
                loadWebsites();
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
