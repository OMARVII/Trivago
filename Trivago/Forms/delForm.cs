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
    public partial class delForm : Form
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
        public delForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void delForm_Load(object sender, EventArgs e)
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
            this.Close();
        }

        private void websiteoffer_Click(object sender, EventArgs e)
        {
            makewebsiteForm a = new makewebsiteForm();
            a.Show();
            this.Hide();
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
            

        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delcust_Click(object sender, EventArgs e)
        {
            DeleteRoom d = new DeleteRoom();
            d.Show();
            d.Hide();
        }

        private void delhotels_Click(object sender, EventArgs e)
        {
            DeleteHotel h = new DeleteHotel();
            h.Show();
            this.Hide();
        }

        private void viewweb_Click(object sender, EventArgs e)
        {
            DeleteWebsite h = new DeleteWebsite();
            h.Show();
            this.Hide();
        }
    }
}
