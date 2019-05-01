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
using CrystalDecisions.Shared;

namespace Trivago.Forms
{
    public partial class HotelsReportViewer : Form
    {
        public HotelsReportViewer()
        {
            InitializeComponent();
        }

        private void HotelsReportViewer_Load(object sender, EventArgs e)
        {
            ViewHotelsReport NewReport = new ViewHotelsReport();
            NewReport.SetParameterValue(0, Forms.ViewHotels.CrystalReportRatingParameter);
            ViewHotels.ReportSource = NewReport;
        }
    }
}
