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
    public partial class WebsiteCrystal : Form
    {
        ViewWebsiteReport generating;

        public WebsiteCrystal()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            generating = new ViewWebsiteReport();
            crystalReportViewer1.ReportSource = generating;
        }
    }
}
