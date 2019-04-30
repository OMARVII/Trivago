using System;
using System.Collections.Generic;
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


namespace Trivago.Forms
{
    public partial class DeleteHotel : Form
    {
        OracleConnection conn;
        string str = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
       

        public DeleteHotel()
        {

            InitializeComponent();
            conn = new OracleConnection(str);
            conn.Open();
            loadHotels();
        }

        void loadHotels()
        {
            hotels.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from hotel ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotels.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void DeleteHotel_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select name from hotel where id=:hotelid ";
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                hotelN.Text = dr["name"].ToString();
            }
        }
        void delLocation()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from location where hotel_id =:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
        }
        void delRoom()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from room where hotel_id =:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();

        }
        void delFeedback()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from User_Hotel_FeedBack where hotel_id =:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
        }

        void delHotel()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from hotel where id=:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("hotel is deleted !");
                loadHotels();
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            delLocation();
            delRoom();
            delFeedback();
            delHotel();
        }

        private void hotelN_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void hotelN_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
