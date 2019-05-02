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
    public partial class MakeWebsitesOffers : Form
    {
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=hr;";
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
        public MakeWebsitesOffers()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            conn = new OracleConnection(connST);
            conn.Open();
            init();
        }
        void init()
        {
            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id , name  from website order by id";
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                AvaliableWebsitesDropdown.Items.Add(dr[0].ToString() + ' ' + dr[1].ToString());
            }
            dr.Close();

            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id , name  from hotel order by id";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               AvaliablHotelsDropdown.Items.Add(dr[0].ToString() + ' ' + dr[1].ToString());
            }
            dr.Close();

        }

        private void TypeCheckBox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (TypeCheckBox.Checked==true)
            {
                RoomsTypePanel.Visible = true;
                SingleRoomPanel.Visible = false;
            }
            else
            {
                RoomsTypePanel.Visible = false;
                SingleRoomPanel.Visible = true;
            }
        }

        private void AvaliablHotelsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hotelID = getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString());
            AvaliableRoomsTypeDropdown.Items.Clear();
            RoomsOfHotelDropdown.Items.Clear();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select  id , type  from room where hotel_id=:hotelid order by id";
            cmd.Parameters.Add("hotelid", hotelID);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RoomsOfHotelDropdown.Items.Add(dr[0].ToString() + ' ' + dr[1].ToString());
                RoomsOfHotelDropdown.SelectedItem = RoomsOfHotelDropdown.Items[0];
            }
            dr.Close();


            
            cmd = new OracleCommand();

            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DISTINCT type  from room where hotel_id=:hotelid order by type";
            cmd.Parameters.Add("hotelid", hotelID);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AvaliableRoomsTypeDropdown.Items.Add(dr[0].ToString() );
                AvaliableRoomsTypeDropdown.SelectedItem = AvaliableRoomsTypeDropdown.Items[0];
            }
            dr.Close();

        }
        

        private string getIdFromTheGivenString(string fullString)
        {
            string st = "";
            string selectedVal = fullString;
            st = selectedVal.Substring(0, selectedVal.IndexOf(' '));
            return st;
        }
        bool validInput()
        {
            if (AvaliablHotelsDropdown.SelectedItem == null || AvaliableWebsitesDropdown.SelectedItem == null || PriceTextbox.Text =="" || !HelperClass.IsDigitsOnly(PriceTextbox.Text))
                return false;
            if (TypeCheckBox.Checked == true && AvaliableRoomsTypeDropdown.SelectedItem == null)
                return false;
            if (TypeCheckBox.Checked == false && RoomsOfHotelDropdown.SelectedItem == null)
                return false;

            return true;
        }
        bool alreadyExistLink(string idToCheck)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Count(*) from room_in_website where room_number=:rid AND hotel_id=:hid AND website_id=:wid";
            cmd.Parameters.Add("rid", idToCheck);
            cmd.Parameters.Add("hid", getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString()));
            cmd.Parameters.Add("wid", getIdFromTheGivenString(AvaliableWebsitesDropdown.SelectedItem.ToString()));
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if(dr[0].ToString()=="0")
                return false;
            return true;
        }
        void deleteExistLink(string idToDelete)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from ROOM_IN_WEBSITE where ROOM_NUMBER=:rid AND HOTEL_ID=:hid AND WEBSITE_ID=:wid";
            cmd.Parameters.Add("rid", idToDelete);
            cmd.Parameters.Add("hid", getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString()));
            cmd.Parameters.Add("wid", getIdFromTheGivenString(AvaliableWebsitesDropdown.SelectedItem.ToString()));
            cmd.ExecuteNonQuery();
            
        }

        void insertLink(string idToInsert)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ROOM_IN_WEBSITE (ROOM_NUMBER , HOTEL_ID , WEBSITE_ID, PRICE) values(:rid,:hid,:wid,:p)";
            cmd.Parameters.Add("rid", idToInsert);
            cmd.Parameters.Add("hid", getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString()));
            cmd.Parameters.Add("wid", getIdFromTheGivenString(AvaliableWebsitesDropdown.SelectedItem.ToString()));
            cmd.Parameters.Add("p", PriceTextbox.Text);
            cmd.ExecuteNonQuery();

        }
        private List <string> getAllRoomsOfTheSameTypeOfHotel()
        {
            List<string> ret = new List<string>();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from room where TYPE=:ty AND HOTEL_ID=:hid";
            cmd.Parameters.Add("ty", AvaliableRoomsTypeDropdown.SelectedItem.ToString());
            cmd.Parameters.Add("hid", getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString()));
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                ret.Add(dr[0].ToString());
            return ret;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(validInput()==false)
            {
                MessageBox.Show("Enter all data");
                return;
            }
            string hotelID = getIdFromTheGivenString(AvaliablHotelsDropdown.SelectedItem.ToString());
                bool doNotoverwrite = false;
            if (TypeCheckBox.Checked == false)
            {
                string selectedID = getIdFromTheGivenString(RoomsOfHotelDropdown.SelectedItem.ToString());
                //check if there is an already offer
                if(alreadyExistLink(selectedID))
                {
                    //ask if he wants to delete
                    DialogResult dialog = MessageBox.Show("There is link already exist you want to overwrite it ?", "YES", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                    {
                        doNotoverwrite = true;
                    }
                    else
                        deleteExistLink(selectedID);
                }
                if (doNotoverwrite==false)
                {
                    //insert new offer if there is no already offer or he accepted to delete
                    insertLink(selectedID);
                    MessageBox.Show("DONE");
                }
            }
            else
            {
                //check if he want to overwrite the already exists
                DialogResult dialog = MessageBox.Show("Do you want to overwrite any previous prices?", "YES", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    MessageBox.Show("we didn't change any prices or add any");
                    return;
                }
                List<string> ids = getAllRoomsOfTheSameTypeOfHotel();
                for (int i = 0; i < ids.Count; i++)
                {
                    //if already exist link delete it
                    if (alreadyExistLink(ids[i]))
                    { 

                        deleteExistLink(ids[i]);
                    }
                        insertLink(ids[i]);
                        
                }
                MessageBox.Show("DONE");
            }
        }
        private void MakeWebsitesOffers_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();

        }

        private void MakeWebsitesOffers_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
    }
}
