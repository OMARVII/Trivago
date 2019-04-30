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
    public partial class ViewCustomers : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string connST = "Data Source=ORCL;User Id=HR;Password=hr;";
        string cmdstr = "select id, first_name as First, last_name as Last, mobile as Mobile, email as Email, gender as Gender from users";
        public ViewCustomers()
        {
            InitializeComponent();
            ds = new DataSet();
            load();
            
        }
        void load()
        {
            adapter = new OracleDataAdapter(cmdstr, connST);
            adapter.Fill(ds);
            usersDataGrid.DataSource = ds.Tables[0];
        }
        private void ViewCustomers_Load(object sender, EventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportBTN_Click(object sender, EventArgs e)
        {
            CustomerReportViewer reportViewer = new CustomerReportViewer();
            reportViewer.ShowDialog();
        }
    }
}
