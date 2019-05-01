using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Trivago.Forms
{
    public partial class makewebsiteForm : Form
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
        public makewebsiteForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void makewebsiteForm_Load(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
            this.Hide();
        }

        private void websiteoffer_Click(object sender, EventArgs e)
        {
           
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            viewForm a = new viewForm();
            a.Show();
            this.Hide();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addForm a = new addForm();
            a.Show();
            this.Hide();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editForm a = new editForm();
            a.Show();
            this.Hide();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            delForm a = new delForm();
            a.Show();
            this.Hide();

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void makeoffers_Click(object sender, EventArgs e)
        {
            MakeWebsitesOffers m = new MakeWebsitesOffers();
            m.Show();
            this.Hide();
        }
    }
}
