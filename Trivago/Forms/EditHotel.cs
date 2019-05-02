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
    public partial class EditHotel : Form
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
        OracleConnection EditHotelConnection;
        string ordb = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        string oldEmail, oldPhoneNumber;
        public EditHotel()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            EditHotelConnection = new OracleConnection(ordb);
            EditHotelConnection.Open();
        }

        private void EditHotel_Load(object sender, EventArgs e)
        {
            LoadHotelNames();
        }
        private void LoadHotelNames()
        {
            OracleCommand HotelNames = new OracleCommand();
            HotelNames.Connection = EditHotelConnection;
            HotelNames.CommandText = " select name from hotel";
            HotelNames.CommandType = CommandType.Text;
            OracleDataReader HotelNameReader = HotelNames.ExecuteReader();
            while (HotelNameReader.Read())
            {
                HotelNameDropDown.Items.Add(HotelNameReader[0]);
            }
            HotelNameReader.Close();
        }

        private void HotelNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetAttributes();
        }
        private void SetAttributes()
        {
            
            OracleCommand GetHotelAttributes = new OracleCommand();
            GetHotelAttributes.Connection = EditHotelConnection;
            GetHotelAttributes.CommandText = "select * from hotel where name = :hotelname";
            GetHotelAttributes.CommandType = CommandType.Text;
            GetHotelAttributes.Parameters.Add("hotelname", HotelNameDropDown.SelectedItem.ToString());
            OracleDataReader HotelAttributesReader = GetHotelAttributes.ExecuteReader();
            if (HotelAttributesReader.Read())
            {
                HotelName.Text = HotelAttributesReader["name"].ToString();
                HotelEmail.Text = HotelAttributesReader["email"].ToString();
                HotelDescription.Text = HotelAttributesReader["description"].ToString();
                HotelNumber.Text = HotelAttributesReader["contact_number"].ToString();
                HotelRating.Value = Convert.ToInt32(HotelAttributesReader["Rating"].ToString());
            }
            oldEmail = HotelEmail.Text;
            oldPhoneNumber = HotelNumber.Text;
            HotelAttributesReader.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                OracleCommand EditHotel = new OracleCommand();
                EditHotel.Connection = EditHotelConnection;
                EditHotel.CommandText = @"update hotel 
                                      set name = :hotelname,
                                      email = :hotelemail,
                                      contact_number= :hotelnumber,
                                      rating = :hotelrating,
                                      description = :hoteldescription
                                      where name = :oldhotelname";
                EditHotel.CommandType = CommandType.Text;
                EditHotel.Parameters.Add("hotelname", HotelName.Text);
                EditHotel.Parameters.Add("hotelemail", HotelEmail.Text);
                EditHotel.Parameters.Add("hotelnumber", HotelNumber.Text);
                EditHotel.Parameters.Add("hotelrating", HotelRating.Value);
                EditHotel.Parameters.Add("hoteldescription", HotelDescription.Text);
                EditHotel.Parameters.Add("oldhotelname", HotelNameDropDown.SelectedItem.ToString());
                int Result = EditHotel.ExecuteNonQuery();
                if (Result != -1)
                {
                    MessageBox.Show("Edited Successfully");
                }
                else
                    MessageBox.Show("Failed To Edit");
            }
            else
                MessageBox.Show("Fix Errors");
        }
        private bool ValidInput()
        {
            if (!ValidNewHotelName())
            {
                NewNameError.SetError(HotelName, "Please Enter A Valid Name");
                return false;
            }
            if (!ValidEmail(HotelEmail.Text))
            {
                NewEmailError.SetError(HotelEmail, "Please Enter A Valid Email");
                return false;
            }
            if (!ValidPhoneNumber(HotelNumber.Text))
            {
                NewNumberError.SetError(HotelNumber, "Please Enter A Valid Phone Number");
                return false;
            }
            if (!HelperClass.ValidRating(HotelRating.Value))
            {
                RatingError.SetError(HotelRating, "Please Insert Hotel Rating");
                return false;
            }
            return true;
        }
        private bool ValidEmail(string Email)
        {
            if (Email != oldEmail)
            {
                if (HelperClass.UniqueHotelNumber(Email,EditHotelConnection))
                    return true;
                return false;
            }
                return true;
        }
        private bool ValidPhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber != oldPhoneNumber)
            {
                if (HelperClass.UniqueHotelNumber(PhoneNumber, EditHotelConnection))
                    return true;
                return false;
            }
            return true;
        }
        private bool ValidNewHotelName()
        {
            if (HotelName.Text == "")
                return false;
           else if (HotelName.Text != HotelNameDropDown.SelectedItem.ToString() )
            {
                OracleCommand HotelNames = new OracleCommand();
                HotelNames.Connection = EditHotelConnection;
                HotelNames.CommandText = "select name from hotel";
                HotelNames.CommandType = CommandType.Text;
                OracleDataReader HotelNameReader = HotelNames.ExecuteReader();
                while (HotelNameReader.Read())
                {
                    if (HotelNameReader[0].ToString() == HotelName.Text)
                    {
                        HotelNameReader.Close();
                        return false;
                    }
                }
                HotelNameReader.Close();
            }
                return true;
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            EditHotelConnection.Close();
            this.Close();

        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            editForm a = new editForm();
            a.ShowDialog();
            this.Close();
        }

        private void EditHotel_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditHotelConnection.Close();
        }
    }
}
