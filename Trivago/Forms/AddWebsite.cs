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
    public partial class AddWebsite : Form
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

        string ordb = "Data Source=orcl;User Id=HR;Password=HR;";
        OracleConnection conn;
        public AddWebsite()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void AddWebsite_Load(object sender, EventArgs e)
        {
            AddWebsiteProgressBar.Hide();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void AddWesbsiteButton_Click(object sender, EventArgs e)
        {
            WebsiteNameError.Dispose();
            AddWebsiteTimer.Start();
            AddWebsiteProgressBar.Show();
            AddWebsiteProgressBar.Value = 0;
            if (WebsiteNameTextBox.Text == "" || WebsiteNameTextBox.Text == "Enter Website Name.")
            {
                WebsiteNameError.SetError(WebsiteNameTextBox, "Please Enter The Website Name");
            }
            else if (IsValidWebsiteName(WebsiteNameTextBox.Text))
            {
                int WebsiteID = getWebsiteId();
                int InsertResult = insertNewWebsite(WebsiteID, WebsiteNameTextBox.Text);
                if (InsertResult != -1)
                {
                    MessageBox.Show("Added Website Successfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }
            }
            else
            {
                WebsiteNameError.SetError(WebsiteNameTextBox, "This Website Is Already Added");
            }
            AddWebsiteProgressBar.Value = 100;
        }
        private bool IsValidWebsiteName(string WebsiteName)
        {
            OracleCommand getWebsiteNames = new OracleCommand();
            getWebsiteNames.Connection = conn;
            getWebsiteNames.CommandText = "getWebsiteNames";
            getWebsiteNames.CommandType = CommandType.StoredProcedure;
            getWebsiteNames.Parameters.Add("Names", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader datareader = getWebsiteNames.ExecuteReader();
            while (datareader.Read())
            {
                if (WebsiteNameTextBox.Text == datareader[0].ToString())
                {
                    datareader.Close();
                    return false;
                }
            }
            datareader.Close();
            return true;
        }
        private int getWebsiteId()
        {
            int WebsiteID;
            OracleCommand getWebsiteIdCmd = new OracleCommand();
            getWebsiteIdCmd.Connection = conn;
            getWebsiteIdCmd.CommandText = "generateWebsiteId";
            getWebsiteIdCmd.CommandType = CommandType.StoredProcedure;
            getWebsiteIdCmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            getWebsiteIdCmd.ExecuteNonQuery();
            try
            {
                WebsiteID = Convert.ToInt32(getWebsiteIdCmd.Parameters["id"].Value.ToString());
                WebsiteID += 1;
            }
            catch
            {
                WebsiteID = 1;
            }
            return WebsiteID;
        }
        private int insertNewWebsite(int WebsiteID, String WebsiteName)
        {
            OracleCommand insertWebsite = new OracleCommand();
            insertWebsite.Connection = conn;
            insertWebsite.CommandText = "insert into website values (:websiteId,:websiteName)";
            insertWebsite.Parameters.Add("websiteId", WebsiteID);
            insertWebsite.Parameters.Add("websiteName", WebsiteName);
            int result = insertWebsite.ExecuteNonQuery();
            return result;
        }
        private void AddWebsiteTimer_Tick(object sender, EventArgs e)
        {
            if (AddWebsiteProgressBar.Value < 100)
                AddWebsiteProgressBar.Value += 1;
            else
                AddWebsiteTimer.Stop();
        }

        private void WebsiteNameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            conn.Close();
        }
    }
}
