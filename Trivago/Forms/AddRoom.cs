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
namespace Trivago.Forms
{
    
    public partial class AddRoom : Form
    {
        
        //Add multiply rooms?
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=ALAAalaa21;";
        public AddRoom()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            init();
        }

        void init()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, name from hotel order by id";
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                AvaliableHotelsDropdown.Items.Add(dr[0].ToString()+' '+ dr[1].ToString());
            }
            dr.Close();

            RoomTypeDropdown.Items.Add("SINGLE");
            RoomTypeDropdown.Items.Add("DOUBLE");
            RoomTypeDropdown.Items.Add("TRIPLE");
            RoomTypeDropdown.Items.Add("QUAD");
        }

        private void AddRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }
        
        private void AvaliableHotelsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewRoomPanel.Visible == false)
                NewRoomPanel.Visible = true;
            string hotelID = getSelectedHotelID();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(id) from room where hotel_id=:id";
            cmd.Parameters.Add("id", hotelID);
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if (dr[0].ToString() == "")
                    RoomIDTextBox.Text = "1";
                else
                    RoomIDTextBox.Text = (int.Parse(dr[0].ToString()) + 1).ToString();
            }
            dr.Close();
        }
        private string getSelectedHotelID()
        {
            string st = "";
            string selectedVal = AvaliableHotelsDropdown.SelectedItem.ToString();
            st = selectedVal.Substring(0, selectedVal.IndexOf(' '));
            return st;
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            if ( AvaliableHotelsDropdown.SelectedItem==null|| RoomTypeDropdown.SelectedItem==null)
            {
                MessageBox.Show("Please enter valid data");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = 
                "insert into room (ID , TYPE,Hotel_id) values(:id,:type,:hotelid)";
            cmd.Parameters.Add("id", RoomIDTextBox.Text);
            cmd.Parameters.Add("type", RoomTypeDropdown.SelectedItem.ToString());
            cmd.Parameters.Add("hotelid", getSelectedHotelID());
            int ret = cmd.ExecuteNonQuery();
            if (ret != -1)
            {
               MessageBox.Show("DONE");
                RoomIDTextBox.Text = (int.Parse(RoomIDTextBox.Text)+1).ToString();
            }
            else
                MessageBox.Show("nooo");

        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

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
