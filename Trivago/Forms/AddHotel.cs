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
namespace Trivago.Forms
{
    public partial class AddHotel : Form
    {
        OracleConnection AddHotelConnection;
        string ordb = "Data Source=orcl;User Id=HR;Password=HR;";
        public AddHotel()
        {
            InitializeComponent();
        }
        private void AddHotel_Load(object sender, EventArgs e)
        {
            AddHotelConnection = new OracleConnection(ordb);
            AddHotelConnection.Open();
        }
        private void AddHotelButton_Click(object sender, EventArgs e)
        {
            bool Result = CheckErrors();
            if (!Result)
            {
                AddHotelToDatabase(HotelName.Text ,getHotelID() , HotelEmail.Text ,HotelContactNumber.Text,HotelDescription.Text,HotelRating.Value,CountryNameTextBox.Text,CityNameTextBox.Text,StreetNameTextBox.Text);
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
            if (CityNameTextBox.Text == "")
            {
                CityError.SetError(CityNameTextBox, "Please Enter the Hotel City");
            }
            if (CountryNameTextBox.Text == "")
            {
                CountryError.SetError(CountryNameTextBox, "Please Enter the Hotel Country");
            }
            if (StreetNameTextBox.Text == "")
            {
                StreetError.SetError(StreetNameTextBox, "Please Enter the Hotel Street");
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
                HotelRatingError.SetError(RatingLabel, "Please Enter Rating For The Hotel");
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
            CountryNameTextBox.Text = "";
            CityNameTextBox.Text = "";
            StreetNameTextBox.Text = "";
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
    }
}
