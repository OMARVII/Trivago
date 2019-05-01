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
    public partial class EditRoom : Form
    {
        OracleConnection EditRoomConnection;
        string ordb = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        int HotelID;
        public EditRoom()
        {
            InitializeComponent();
        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            EditRoomConnection = new OracleConnection(ordb);
            EditRoomConnection.Open();
            LoadHotelNames();
        }
        private void LoadHotelNames()
        {
            OracleCommand getHotelNames = new OracleCommand();
            getHotelNames.Connection = EditRoomConnection;
            getHotelNames.CommandText = "getHotelNames";
            getHotelNames.CommandType = CommandType.StoredProcedure;
            getHotelNames.Parameters.Add("HotelNames", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader datareader = getHotelNames.ExecuteReader();
            while (datareader.Read())
            {
                HotelNameDropDown.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
        }
        private void LoadRoomsID(int HotelID)
        {
            OracleCommand getRoomIDS = new OracleCommand();
            getRoomIDS.Connection = EditRoomConnection;
            getRoomIDS.CommandText = "getRoomIDS";
            getRoomIDS.CommandType = CommandType.StoredProcedure;
            getRoomIDS.Parameters.Add("HotelID",HotelID);
            getRoomIDS.Parameters.Add("RoomIDS", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dataReader = getRoomIDS.ExecuteReader();
            while (dataReader.Read())
            {
                RoomIdDropDown.Items.Add(dataReader[0].ToString());
            }
            dataReader.Close();
        }
        private void LoadRoomType()
        {
            int RoomID = Convert.ToInt32(RoomIdDropDown.SelectedItem.ToString());
            RoomTypeDropDown.Text = HelperClass.getRoomType(RoomID,HotelID,EditRoomConnection);
            RoomTypeDropDown.Items.Add("SINGLE");
            RoomTypeDropDown.Items.Add("DOUBLE");
            RoomTypeDropDown.Items.Add("TRIPLE");
            RoomTypeDropDown.Items.Add("QUAD");
        }
        private void HotelNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomIdDropDown.Text = "Room ID";
            RoomTypeDropDown.Text = "Room Type";
            RoomIdDropDown.Items.Clear();
            HotelID = HelperClass.getHotelID(HotelNameDropDown.SelectedItem.ToString(), EditRoomConnection);
            LoadRoomsID(HotelID);
        }
        private void RoomIdDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomTypeDropDown.Items.Clear();
            LoadRoomType();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                OracleCommand Submit = new OracleCommand();
                Submit.Connection = EditRoomConnection;
                Submit.CommandText = "update room set type = :Type where id = :roomid and hotel_id =:HotelID";
                Submit.Parameters.Add("Type", RoomTypeDropDown.SelectedItem.ToString());
                Submit.Parameters.Add("roomid", Convert.ToInt32(RoomIdDropDown.SelectedItem.ToString()));
                Submit.Parameters.Add("HotelID", HotelID);
                Submit.CommandType = CommandType.Text;
                int result = Submit.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("Edited Successfully");
                }
                else
                    MessageBox.Show("Failed To Edit");
            }
            else
            {
                MessageBox.Show("Please Enter Valid Input");
            }
        }
        private bool ValidInput()
        {
            if (HotelNameDropDown.SelectedIndex == -1 || RoomIdDropDown.SelectedIndex == -1 || RoomTypeDropDown.SelectedIndex == -1)
                return false;
            return true;
        }
    }
}
