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
using System.Runtime.InteropServices;
namespace Trivago.Forms
{
    public partial class DeleteRoom : Form
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
        string connST = "Data Source=ORCL;User Id=HR;Password=hr;";
        public DeleteRoom()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        void init()
        {
            hotelDropDown.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from hotel";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotelDropDown.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        private void hotelDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomDropDown.Items.Clear();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from room where hotel_id=:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("hotelid", hotelDropDown.SelectedItem);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                roomDropDown.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        void delWebsiteInRoom()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from Room_In_Website where Room_Number =:roomid and hotel_id =:hotelid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("roomid", roomDropDown.SelectedItem.ToString());
            cmd.Parameters.Add("hotelid", hotelDropDown.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
        }
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            delWebsiteInRoom();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "deleteRoom";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("hID", hotelDropDown.SelectedItem.ToString());
            cmd.Parameters.Add("rID", roomDropDown.SelectedItem.ToString());
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Room Successfully Deleted!");
            }
            else MessageBox.Show("Something Wrong!");
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteRoom_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
