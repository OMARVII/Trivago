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
using Trivago.Classes;
using System.Runtime.InteropServices;
namespace Trivago.Forms
{
    public partial class AddHotel : Form
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
        OracleConnection AddHotelConnection;
        string ordb = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        public AddHotel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            AddHotelConnection = new OracleConnection(ordb);
            AddHotelConnection.Open();
        }
        private void AddHotel_Load(object sender, EventArgs e)
        {
            LoadUserLabel();   
        }
        private void LoadUserLabel()
        {
            OracleCommand getUserName = new OracleCommand();
            getUserName.Connection = AddHotelConnection;
            getUserName.CommandText = "select first_name from users where id = :userid";
            getUserName.CommandType = CommandType.Text;
            getUserName.Parameters.Add("userid", Convert.ToInt32(Forms.Login.userID));
            OracleDataReader UserName = getUserName.ExecuteReader();
            if (UserName.Read())
            {
                WelcomeLabel.Text = "Welcome " + UserName[0].ToString() + "!";
            }
            UserName.Close();
        }
        private void AddHotelButton_Click(object sender, EventArgs e)
        {
            bool Result = CheckErrors();
            if (!Result)
            {
                AddHotelToDatabase(HotelName.Text ,getHotelID() , HotelEmail.Text ,HotelContactNumber.Text,HotelDescription.Text,HotelRating.Value,HotelCountry.Text,HotelCity.Text,HotelStreet.Text);
                MessageBox.Show("Hotel Added Successfully :)");
                ClearFields();
                ClearErrors();
            }
            else
            {
                MessageBox.Show("Check the errors :)");
            }
        }
        private bool CheckErrors()
        {
            bool Result = false;
            if (HotelCity.Text == "")
            {
                CityError.SetError(HotelCity, "Please Enter the Hotel City");
            }
            if (HotelCountry.Text == "")
            {
                CountryError.SetError(HotelCountry, "Please Enter the Hotel Country");
            }
            if (HotelStreet.Text == "")
            {
                StreetError.SetError(HotelStreet, "Please Enter the Hotel Street");
            }
            if (!ValidHotelName(HotelName.Text))
            {
                HotelNameError.SetError(HotelName, "This Hotel Name Already Exists");
                Result = true;
            }
            if (!HelperClass.ValidEmail(HotelEmail.Text) || !HelperClass.UniqueHotelEmail(HotelEmail.Text,AddHotelConnection) )
            {
                HotelEmailError.SetError(HotelEmail, "This Email Is Not Valid or Already Exists");
                Result = true;
            }
            if (!HelperClass.ValidPhoneNumber(HotelContactNumber.Text) || !HelperClass.UniqueHotelNumber(HotelContactNumber.Text,AddHotelConnection))
            {
                NumberError.SetError(HotelContactNumber, "The Number Format You Entered Wrong, Correct Form 12 numbers Or Already Exists");
                Result = true;
            }
            if (!HelperClass.ValidRating(HotelRating.Value))
            {
                HotelRatingError.SetError(HotelRating, "Please Enter Rating For The Hotel");
                Result = true;
            }
            return Result;

        }
        private bool ValidHotelName(string HotelName)
        {
            if (HotelName == "")
                return false;
            OracleCommand getHotelNames = new OracleCommand();
            getHotelNames.Connection = AddHotelConnection;
            getHotelNames.CommandText = "getHotelNames";
            getHotelNames.CommandType = CommandType.StoredProcedure;
            getHotelNames.Parameters.Add("HotelNames", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader datareader = getHotelNames.ExecuteReader();
            while (datareader.Read())
            {
                if (HotelName == datareader[0].ToString())
                {
                    datareader.Close();
                    return false;
                }
            }
            datareader.Close();
            return true;
        }
        private int getHotelID()
        {
            int HotelID;
            OracleCommand getHotelIdCmd = new OracleCommand();
            getHotelIdCmd.Connection = AddHotelConnection;
            getHotelIdCmd.CommandText = "generateHotelId";
            getHotelIdCmd.CommandType = CommandType.StoredProcedure;
            getHotelIdCmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            getHotelIdCmd.ExecuteNonQuery();
            try
            {
                HotelID = Convert.ToInt32(getHotelIdCmd.Parameters["id"].Value.ToString());
                HotelID += 1;
            }
            catch
            {
                HotelID = 1;
            }
            return HotelID;
        }
        private void AddHotelToDatabase(string name , int id ,string email , string number ,string description , int rating , string country , string city,string street)
        {
            OracleCommand addhotel = new OracleCommand();
            addhotel.Connection = AddHotelConnection;
            addhotel.CommandText = "AddHotel";
            addhotel.CommandType = CommandType.StoredProcedure;
            addhotel.Parameters.Add("HotelName", name);
            addhotel.Parameters.Add("HotelID", id);
            addhotel.Parameters.Add("HotelEmail", email);
            addhotel.Parameters.Add("HotelNumber", number);
            addhotel.Parameters.Add("HotelRating", rating);
            addhotel.Parameters.Add("HotelDescription", description);
            addhotel.Parameters.Add("HotelCountry", country);
            addhotel.Parameters.Add("HotelCity", city);
            addhotel.Parameters.Add("HotelStreet", street);
            addhotel.ExecuteNonQuery();
        }
        private void ClearFields()
        {
            HotelName.Text = "";
            HotelEmail.Text = "";
            HotelDescription.Text ="";
            HotelRating.Value = 0;
            HotelCountry.Text = "";
            HotelCity.Text = "";
            HotelStreet.Text = "";
            HotelContactNumber.Text = "";
        }
        private void ClearErrors()
        {
            HotelNameError.Dispose();
            HotelEmailError.Dispose();
            NumberError.Dispose();
            DescriptionError.Dispose();
            HotelRatingError.Dispose();
            CountryError.Dispose();
            StreetError.Dispose();
            CityError.Dispose();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(AddHotelConnection.State == ConnectionState.Open)
                AddHotelConnection.Close();
            Application.Exit();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addForm a = new addForm();
            a.ShowDialog();
            this.Close();
        }
    }
}
