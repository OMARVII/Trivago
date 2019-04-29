using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Trivago.Forms
{
    public partial class LoadingScreen : Form
    {
        int val ;
        public LoadingScreen()
        {
            InitializeComponent();
            val = 0;
        }
    
        private void LoadingScreen_Load(object sender, EventArgs e)
        {}

        private void timer1_Tick(object sender, EventArgs e)
        {
            val += timer1.Interval;
            progressBar1.Increment(1);
            if (val >= timer1.Interval*100)
                this.Close();

        }
    }
}
