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
    public partial class editForm : Form
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
        public editForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }


        private void editForm_Load(object sender, EventArgs e)
        {

        }

        private void addAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.ShowDialog();
            this.Close();
        }

        private void websiteoffer_Click(object sender, EventArgs e)
        {
            this.Hide();
            makewebsiteForm a = new makewebsiteForm();
            a.ShowDialog();
            this.Close();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewForm a = new viewForm();
            a.ShowDialog();
            this.Close();

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addForm a = new addForm();
            a.ShowDialog();
            this.Close();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            delForm a = new delForm();
            a.ShowDialog();
            this.Close();

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editcust_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRoom a = new EditRoom();
            a.ShowDialog();
            this.Close();
        }

        private void edithotels_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditHotel a = new EditHotel();
            a.ShowDialog();
            this.Close();
        }

        private void editweb_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditWebsite a = new EditWebsite();
            a.ShowDialog();
            this.Close();
        }
    }
}
