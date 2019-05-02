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
    public partial class EditWebsite : Form
    {
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=ALAAalaa21;";
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
        public EditWebsite()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            loadWebsites();
        }
        void loadWebsites()
        {
            websiteDropDown.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from website";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                websiteDropDown.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        private void websiteDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            if(newNameBox.Text =="" || newNameBox.Text.Length <= 2)
            {
                MessageBox.Show("Please enter a vaild name");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "updateWebsite";
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.Add("Wname",newNameBox.Text );
            cmd.Parameters.Add("old", websiteDropDown.SelectedItem.ToString());
            int result = cmd.ExecuteNonQuery();
            if (result !=0)
            {
                MessageBox.Show("Updated Successfully!");
                loadWebsites();
            }
            else MessageBox.Show("Something Wrong!");
        }

        private void EditWebsite_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newNameBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
