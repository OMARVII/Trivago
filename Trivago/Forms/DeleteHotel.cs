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
using System.Runtime.InteropServices;

namespace Trivago.Forms
{
    public partial class DeleteHotel : Form
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
        OracleConnection conn;
        string str = "Data Source=orcl;User Id=HR;Password=ALAAalaa21;";
        string deletedID = "";


        public DeleteHotel()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
        Boolean validate()
        {
            if (hotels.SelectedIndex == -1 && deletedID != "")
            {
                MessageBox.Show("already deleted");
                return true;
            }
            if (hotels.SelectedIndex == -1)
            {
                MessageBox.Show("Choose an id");
                return true;
            }
            return false;
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
        void delRoomInWebsite()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Room_In_Website where hotel_id =:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotels.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
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
                deletedID = hotels.SelectedItem.ToString();
                loadHotels();
               
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (validate()) return;
            delRoomInWebsite();
                delLocation();
                delRoom();
                delHotel();

           


        }

        private void hotelN_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void hotelN_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
