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

namespace Trivago.Forms
{
    public partial class ViewWebsite : Form
    {   
        string constr = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        ViewWebsiteReport generating;
        public ViewWebsite()
        {
            InitializeComponent();
       
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            ViewWebsiteTimer.Start();

            pb2.Show();

            pb2.Value = 0;

            OracleDataAdapter adapter;
            //OracleCommandBuilder builder;
            DataSet ds;
            pb2.Value = 25;
            string cmdstr = "select* from website";
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
            ViewWebsiteTimer.Start();
            pb2.Show();
            pb2.Value = 0;

            WebsiteCrystal crys = new WebsiteCrystal();
            pb2.Value = 50;
            crys.Show();
            pb2.Value = 100;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
