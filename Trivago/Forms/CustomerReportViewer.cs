using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trivago.CrystalReports;
namespace Trivago.Forms
{
    public partial class CustomerReportViewer : Form
    {
        public CustomerReportViewer()
        {
            InitializeComponent();
            ViewCustomersReport report = new ViewCustomersReport();
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
