using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Trivago.CrystalReports;

namespace Trivago
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            this.Hide();
            Thread Loading = new Thread(new ThreadStart(runSplash));
            Forms.Register r = new Forms.Register();
            Loading.Start();
           
            r.ShowDialog();
            Loading.Abort();
            this.Close();
            

        }
        private void runSplash()
        {
            Application.Run(new Forms.LoadingScreen());
            Thread.Sleep(5000);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
