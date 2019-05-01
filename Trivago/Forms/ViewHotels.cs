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
using Trivago.Classes;
namespace Trivago.Forms
{
    public partial class ViewHotels : Form
    {
        public static int CrystalReportRatingParameter;
        bool FirstTime = true;
        OracleCommandBuilder commandBuilder;
        DataSet dataset;
        string ordb = "Data Source=orcl;User Id=HR;Password=HR;";
        public ViewHotels()
        {
            InitializeComponent();
        }

        private void ViewHotels_Load(object sender, EventArgs e)
        {
            RoomsDataGrid.Hide();
            dataset = new DataSet();
            string ViewHotelsCommand = "select id as ID ,name as Name , email as Email , contact_number as Phone_Number , rating as Rating ,description as Description from hotel";
            OracleDataAdapter hotelAdapter = new OracleDataAdapter(ViewHotelsCommand,ordb);
            hotelAdapter.Fill(dataset, "Hotels");
            HotelDataGrid.DataSource = dataset.Tables[0];
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            RoomsDataGrid.Show();
            string ViewRoomsCommand = "select * from room ";
            string Type = "";
            if (SingleRadio.Checked)
                Type = "where type = 'SINGLE'";
            else if (DoubleRadio.Checked)
                Type = "where type = 'DOUBLE'";
            else if (TripleRadio.Checked)
                Type = "where type = 'TRIPLE'";
            else if (QuadRadio.Checked)
                Type = "where type = 'QUAD'";
            ViewRoomsCommand += Type;
            OracleDataAdapter roomAdapter = new OracleDataAdapter(ViewRoomsCommand, ordb);
            if (FirstTime)
            {
                roomAdapter.Fill(dataset, "rooms");
                DataRelation Hotel_Room_Relation = new DataRelation("Hotel_ID", dataset.Tables[0].Columns["ID"], dataset.Tables[1].Columns["Hotel_ID"]);
                dataset.Relations.Add(Hotel_Room_Relation);
                FirstTime = false;
            }
            else
            {
                dataset.Tables["rooms"].Constraints.Clear();
                dataset.Relations.Remove("Hotel_ID");
                dataset.Tables.Remove("rooms");
                roomAdapter.Fill(dataset, "rooms");
                DataRelation Hotel_Room_Relation = new DataRelation("Hotel_ID", dataset.Tables[0].Columns["ID"], dataset.Tables[1].Columns["Hotel_ID"]);
                dataset.Relations.Add(Hotel_Room_Relation);
            }
            BindingSource BS_Hotel = new BindingSource(dataset, "Hotels");
            BindingSource BS_RoomsChild = new BindingSource(BS_Hotel, "Hotel_ID");
            HotelDataGrid.DataSource = BS_Hotel;
            RoomsDataGrid.DataSource = BS_RoomsChild;
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (HotelRating.Text == "" || !HelperClass.ValidRating(Convert.ToInt32(HotelRating.Text)))
            {
                HotelRatingError.SetError(HotelRating, "Please Enter Valid Rating");
            }
            else
            {
                CrystalReportRatingParameter = Convert.ToInt32(HotelRating.Text);
                HotelsReportViewer Report = new HotelsReportViewer();
                Thread Loading = new Thread(new ThreadStart(runSplash));
                Loading.Start();
                Report.ShowDialog();
                Loading.Abort();
            }
        }
        private void runSplash()
        {
            Application.Run(new LoadingScreen());
            Thread.Sleep(5000);
        }
    }
}
