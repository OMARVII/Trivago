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
    public partial class EditWebsite : Form
    {
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=ALAAalaa21;";
        public EditWebsite()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
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
            cmd.CommandText = "update website set name=:newName";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("newName", newNameBox.Text);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Updated Successfully!");
                loadWebsites();
            }
            else MessageBox.Show("Something Wrong!");
        }

        private void EditWebsite_Load(object sender, EventArgs e)
        {

        }
    }
}
