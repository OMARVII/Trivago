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
using Trivago.CrystalReports;
using System.Runtime.InteropServices;

namespace Trivago.Forms
{
    public partial class ViewWebsite : Form
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
        string constr = "Data Source=orcl;User Id=HR;Password=hr;";

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ViewWebsite()
        {
            conn = new OracleConnection(constr);

            conn.Open();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


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

        private void view_Click(object sender, EventArgs e)
        {
            

            pb2.Value = 0;

     
            //OracleCommandBuilder builder;
      
            pb2.Value = 25;
            string cmdstr = "select* from website order by id";
            adapter = new OracleDataAdapter(cmdstr, constr);
            pb2.Value = 50;
            ds  = new DataSet();
            adapter.Fill(ds);
            pb2.Value = 75;
            dgview.DataSource = ds.Tables[0];

            pb2.Value = 100;


        }

        private void ViewWebsite_Load(object sender, EventArgs e)
        {
           
        }

        private void generate_Click(object sender, EventArgs e)
        {
           
            pb2.Value = 0;

            WebsiteCrystal crys = new WebsiteCrystal();
            pb2.Value = 50;
            crys.Show();
            pb2.Value = 100;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void pb2_progressChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                builder = new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Updated!");
            }
            catch
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
