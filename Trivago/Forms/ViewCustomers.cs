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
    public partial class ViewCustomers : Form
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
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        string connST = "Data Source=ORCL;User Id=HR;Password=ALAAalaa21;";
        string cmdstr = "select id, first_name as First, last_name as Last, mobile as Mobile, email as Email, gender as Gender, date_of_birth as BirthDate from users";
        public ViewCustomers()
        {
            InitializeComponent();
            ds = new DataSet();
            load();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

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

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportBTN_Click_1(object sender, EventArgs e)
        {
            CustomerReportViewer reportViewer = new CustomerReportViewer();
            reportViewer.ShowDialog();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewForm a = new viewForm();
            a.ShowDialog();
            this.Close();
        
    }
    }
}
