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
    public partial class ReserveRoom : Form
    {
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=HR;";
        public ReserveRoom()
        {
            InitializeComponent();
            init();

        }
        void init()
        {
            conn = new OracleConnection(connST);
            conn.Open();
            RoomTypeDropdown.Items.Add("SINGLE");
            RoomTypeDropdown.Items.Add("DOUBLE");
            RoomTypeDropdown.Items.Add("TRIPLE");
            RoomTypeDropdown.Items.Add("QUAD");
            RoomTypeDropdown.SelectedItem = RoomTypeDropdown.Items[0];
        }
        private void SearchTextbox_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        void fillDisplayPanel(string toFind)
        {
            fillPanelByX("h.name");
            fillPanelByX("l.country");
            fillPanelByX("l.city");
            fillPanelByX("l.street");
        }

        void fillPanelByX( string x)
        {
            string cmdSTR = @"select DISTINCT w.name as websitename , h.name as hotelname, h.rating as hotelrate , r.id as roomid, r.type as roomtype, riw.price as price , l.country as country, l.city as city, l.street as street
from website w , room r, hotel h , room_in_website riw, location l where
"+x+@" LIKE :toFind
AND
riw.hotel_id = l.hotel_id
AND
r.hotel_id = l.hotel_id
AND
h.id = l.hotel_id
AND
r.type = :type
AND
r.id = riw.room_number
AND
w.id = riw.website_id";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdSTR;
            cmd.Parameters.Add("toFind",'%'+ SearchTextbox.Text+'%');
            cmd.Parameters.Add("type", RoomTypeDropdown.SelectedItem.ToString());

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                addControlToPanel(dr);
            }
            dr.Close();
        }
        Bunifu.Framework.UI.BunifuCustomLabel getNewLabel(int x , int y , string text)
        {

            Bunifu.Framework.UI.BunifuCustomLabel temp = new Bunifu.Framework.UI.BunifuCustomLabel();
            temp.Location = new Point(x,y);
            temp.Text = text;
            temp.AutoSize = true;
            return temp;
        }
        void addControlToPanel(OracleDataReader dr)
        {
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel newControl = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            newControl.Location = new Point(0, 0);
            newControl.Width = DisplayPanel.Width;
            newControl.Height = 135;
            if (DisplayPanel.Controls.Count != 0)
            {

                Control lastElement = DisplayPanel.Controls[DisplayPanel.Controls.Count - 1];
                newControl.Location = new Point(0, lastElement.Location.Y+ lastElement.Height );
            }
            

            Bunifu.Framework.UI.BunifuRating hotelRating = new Bunifu.Framework.UI.BunifuRating();
            hotelRating.Value = int.Parse( dr["hotelrate"].ToString() ) ;
            hotelRating.Location = new Point(4,35);
            hotelRating.Size = new Size(244, 37);
            hotelRating.Enabled = false;
            newControl.Controls.Add(hotelRating);

            newControl.Controls.Add(getNewLabel(4,4 , "hotel name : "+ dr["hotelname"].ToString()));
            newControl.Controls.Add(getNewLabel(3, 86, "location : "+ dr["country"].ToString() + " , " + dr["city"].ToString() + " , " + dr["street"].ToString()));

            newControl.Controls.Add(getNewLabel(300, 4, "room id : "+dr["roomid"].ToString()));
            newControl.Controls.Add(getNewLabel(300, 46, "room type : "+ dr["roomtype"].ToString()));
            newControl.Controls.Add(getNewLabel(300, 86, "price : "+ dr["price"].ToString()));
            newControl.Controls.Add(getNewLabel(530, 45, "website name : "+ dr["websitename"].ToString()));

            DisplayPanel.Controls.Add(newControl);
            
        }

        private void viewOffersButton_Click(object sender, EventArgs e)
        {
            string searchBy = SearchTextbox.Text.ToString();
            DisplayPanel.Controls.Clear();
            fillDisplayPanel(searchBy);
        }
    }
}
