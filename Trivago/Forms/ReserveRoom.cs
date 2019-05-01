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
        Dictionary<Tuple<string, Tuple<string, string>>, bool> alreadyAddedOffer;
        Dictionary<Tuple<string, string>, int> alreadyAddedPanels;

        public ReserveRoom()
        {
            InitializeComponent();
            init();
            alreadyAddedOffer = new Dictionary<Tuple<string, Tuple<string, string>>, bool>();
            alreadyAddedPanels = new Dictionary<Tuple<string, string>, int>();
            this.Size = new Size(1230, 660);
            this.AutoSize = false;
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
            fillDisplayPanel();
        }

        void fillDisplayPanel()
        {
            DisplayPanel.Controls.Clear();
            alreadyAddedOffer = new Dictionary<Tuple<string, Tuple<string, string>>, bool>();
            alreadyAddedPanels = new Dictionary<Tuple<string, string>, int>();
            fillPanelByX("h.name");
            fillPanelByX("l.country");
            fillPanelByX("l.city");
            fillPanelByX("l.street");
            fillPanelsWithButtonsPanel();
        }

        void fillPanelsWithButtonsPanel()
        {
            foreach (Control hotelOffer in DisplayPanel.Controls)
            {
                string minWebsiteName = "";
                int miniPrice = -1;
                Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel websitesPanel = (Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel)hotelOffer.Controls["websitesInfoPanel"];
                foreach (Control websitePanel in websitesPanel.Controls)
                {
                    string websiteName = getWebsiteNameFromPanel(websitePanel);
                    int tempPrice = getWebsitePriceFromPanel(websitePanel);
                    if(miniPrice==-1)
                    {
                        miniPrice = tempPrice;
                        minWebsiteName = websiteName;
                    }
                    else if (miniPrice>tempPrice)
                    {
                        miniPrice = tempPrice;
                        minWebsiteName = websiteName;

                    }
                }

                Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel reservePanel = (Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel) hotelOffer.Controls["reservePanel"];

                Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel newWebsitePanel = getWebsitePanel();
                newWebsitePanel.Controls.Add(getNewLabel(4, 4, "website name : " + minWebsiteName));
                newWebsitePanel.Controls.Add(getNewLabel(194, 4, "price : " + miniPrice.ToString()));
                //newWebsitePanel.Dock = DockStyle.Top;
                //newWebsitePanel.AutoSize = true;
                
                //Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel newButtonPanel = getWebsitePanel();
                //newButtonPanel.Dock = DockStyle.Top;
                //newButtonPanel.AutoSize = true;


                Bunifu.UI.WinForms.BunifuButton.BunifuButton reserveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                reserveButton.Tag =  getButtonHotelIdFromControl(hotelOffer)+' ' + getButtonRoomIdFromControl(hotelOffer) ;
                reserveButton.Click += new EventHandler(reserveButton_Click);
                reserveButton.Dock = DockStyle.Top;
                //reserveButton.Size = new Size(305, 125);
                //reserveButton.AutoSize = true;
                

                //newButtonPanel.Controls.Add(reserveButton);

                reservePanel.Controls.Add(reserveButton);
                reservePanel.Controls.Add(newWebsitePanel);
                
            }
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            string fullTag = ((Control)sender).Tag.ToString();
            int hotelID = int.Parse(fullTag.Split(' ')[0]);
            int roomID = int.Parse(fullTag.Split(' ')[1]);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "reserveRoom";

            cmd.Parameters.Add("hotelid", hotelID.ToString());
            cmd.Parameters.Add("roomid", roomID.ToString());
            cmd.Parameters.Add("reserveFROM", reserveFrom.Value.ToString("dd-MMM-yy"));
            cmd.Parameters.Add("reserveTO", reserveTo.Value.ToString("dd-MMM-yy"));

            int r = cmd.ExecuteNonQuery();
            if (r == 0)
            {

                MessageBox.Show("SOME ERROR");
            }
            else
            {
                MessageBox.Show("Done RESERVING");
                fillDisplayPanel();
            }
        }
        string getButtonHotelIdFromControl(Control control)
        {
            string ret = "";
            ret= control.Controls["hotelInfoPanel"].Tag.ToString();
            return ret;
        }
        string getButtonRoomIdFromControl(Control control)
        {

            string ret = "";
            ret = control.Controls["roomInfoPanel"].Tag.ToString();

            return ret;
        }
        string getWebsiteNameFromPanel(Control control)
        {
            string ret = "";
            Bunifu.Framework.UI.BunifuCustomLabel label = (Bunifu.Framework.UI.BunifuCustomLabel)control.Controls[0];
            ret = label.Text.Substring("website name : ".Length);
            return ret;
        }
        int getWebsitePriceFromPanel(Control control)
        {
            string ret = "";
            Bunifu.Framework.UI.BunifuCustomLabel label = (Bunifu.Framework.UI.BunifuCustomLabel)control.Controls[1];
            ret = label.Text.Substring("price : ".Length);
            return int.Parse( ret);
        }
        void fillPanelByX( string x)
        {
            string cmdSTR = @"select DISTINCT w.name as websitename,w.id as websiteid,h.id as hotelid , h.name as hotelname, h.rating as hotelrate , r.id as roomid, r.type as roomtype, riw.price as price , l.country as country, l.city as city, l.street as street , r.reserved_from as rfrom , r.reserved_to as rto
from website w , room r, hotel h , room_in_website riw, location l where
" + x+@" LIKE :toFind
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
w.id = riw.website_id
AND
(
(:newFrom>=r.reserved_to)
OR
(:newTo<=r.reserved_from)
)
";
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdSTR;
            cmd.Parameters.Add("toFind",'%'+ SearchTextbox.Text+'%');
            cmd.Parameters.Add("type", RoomTypeDropdown.SelectedItem.ToString());
            cmd.Parameters.Add("newFrom", reserveFrom.Value.ToString("dd-MMM-yy"));
            cmd.Parameters.Add("newTo", reserveTo.Value.ToString("dd-MMM-yy"));
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Tuple<string, string> tuple = Tuple.Create(dr["hotelid"].ToString(), dr["roomtype"].ToString());

                if (alreadyAddedOffer.ContainsKey(Tuple.Create(dr["websiteid"].ToString(), tuple)))
                    continue;
                else
                    alreadyAddedOffer[Tuple.Create(dr["websiteid"].ToString(), tuple)] = true;

                if (!alreadyAddedPanels.ContainsKey(tuple))
                    addControlToPanel(dr);
                else
                    addWebsiteToExistingPanel(dr);
            }
            dr.Close();
        }
        void addWebsiteToExistingPanel(OracleDataReader dr)
        {
            Tuple<string, string> tuple = Tuple.Create(dr["hotelid"].ToString(), dr["roomtype"].ToString());

            int panelID = alreadyAddedPanels[tuple];

            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel websitesPanel = (Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel) DisplayPanel.Controls[panelID].Controls["websitesInfoPanel"];


            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel websitePanel = getWebsitePanel();

            //int newY = websitesPanel.Controls[websitesPanel.Controls.Count - 1].Location.Y+60;

            websitePanel.Controls.Add(getNewLabel(4, 4, "website name : " + dr["websitename"].ToString()));
            websitePanel.Controls.Add(getNewLabel(194, 4, "price : " + dr["price"].ToString()));
            websitesPanel.Controls.Add(websitePanel);

        }
        Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel getInsidePanel()
        {
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel ret = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            ret.Dock = DockStyle.Left;
            ret.Size = new Size(305, 135);
            ret.MouseEnter += new EventHandler(tempPanel_MouseEnter);
            ret.MouseLeave += new EventHandler(tempPanel_MouseLeave);

            return ret;
        }
        Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel getWebsitePanel()
        {
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel ret = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            ret.Dock = DockStyle.Top;
            ret.Size = new Size(120, 50);
            ret.MouseEnter += new EventHandler(tempPanel_MouseEnter);
            ret.MouseLeave += new EventHandler(tempPanel_MouseLeave);
            return ret;
        }
        void addControlToPanel(OracleDataReader dr)
        {
            Tuple<string, string> tuple = Tuple.Create(dr["hotelid"].ToString(), dr["roomtype"].ToString());

            alreadyAddedPanels[tuple] = DisplayPanel.Controls.Count;
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel newControl = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            newControl.ShadowDept = 2;
            newControl.Dock = DockStyle.Top;
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel hotelInfoPanel = getInsidePanel();
            hotelInfoPanel.Name = "hotelInfoPanel";

            Bunifu.Framework.UI.BunifuRating hotelRating = new Bunifu.Framework.UI.BunifuRating();
            hotelRating.Value = int.Parse( dr["hotelrate"].ToString() ) ;
            hotelRating.Location = new Point(4,35);
            hotelRating.Size = new Size(240, 40);
            hotelRating.Enabled = false;
            hotelInfoPanel.Controls.Add(hotelRating);
            
            hotelInfoPanel.Controls.Add(getNewLabel(4,4 , "hotel name : "+ dr["hotelname"].ToString()));
            hotelInfoPanel.Controls.Add(getNewLabel(3, 80, "location : "+ dr["country"].ToString() + " , " + dr["city"].ToString() + " , " + dr["street"].ToString()));


            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel roomInfoPanel = getInsidePanel();
            roomInfoPanel.Name = "roomInfoPanel";
            roomInfoPanel.Controls.Add(getNewLabel(4, 4, "room id : "+dr["roomid"].ToString()));
            roomInfoPanel.Controls.Add(getNewLabel(4, 46, "room type : "+ dr["roomtype"].ToString()));

            
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel websitesPanel = getInsidePanel();
            websitesPanel.AutoScroll = true;
            //websitesPanel.AutoSize = true;
            websitesPanel.Name = "websitesInfoPanel";
            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel websitePanel = getWebsitePanel();

            websitePanel.Controls.Add(getNewLabel(4, 4, "website name : "+ dr["websitename"].ToString()));
            websitePanel.Controls.Add(getNewLabel(194, 4, "price : "+ dr["price"].ToString()));

            websitesPanel.Controls.Add(websitePanel);

            Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel reservePanel = getInsidePanel();
            reservePanel.Name = "reservePanel";
            
            hotelInfoPanel.Tag = dr["hotelid"].ToString();
            roomInfoPanel.Tag = dr["roomid"].ToString();

            newControl.Controls.Add(reservePanel);
            newControl.Controls.Add(websitesPanel);
            newControl.Controls.Add(roomInfoPanel);
            newControl.Controls.Add(hotelInfoPanel);

            DisplayPanel.Controls.Add(newControl);
        }
        Bunifu.Framework.UI.BunifuCustomLabel getNewLabel(int x, int y, string text)
        {

            Bunifu.Framework.UI.BunifuCustomLabel temp = new Bunifu.Framework.UI.BunifuCustomLabel();
            temp.Location = new Point(x, y);
            temp.Text = text;
            temp.AutoSize = true;
            return temp;
        }
        private void viewOffersButton_Click(object sender, EventArgs e)
        {
            
            fillDisplayPanel();
        }

        private void reserveFrom_ValueChanged(object sender, EventArgs e)
        {
            if (reserveFrom.Value >= reserveTo.Value)
                reserveTo.Value = reserveFrom.Value.AddDays(1);
            fillDisplayPanel();
        }

        private void reserveTo_ValueChanged(object sender, EventArgs e)
        {
            if (reserveFrom.Value >= reserveTo.Value)
                reserveTo.Value = reserveFrom.Value.AddDays(1);
            fillDisplayPanel();
        }

        private void RoomTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDisplayPanel();
        }



        private void tempPanel_MouseEnter(object sender, EventArgs e)
        {

            //if (((Control)sender).Tag.ToString() == "main")
            //    return;
            //((Control)sender).Size += new Size(10,10);
            ((Control)sender).BackColor = Color.LightBlue;
            /*
            foreach (Control item in ((Control)sender).Controls)
            {
                if (item.BackColor != Color.LightBlue)
                    tempPanel_MouseEnter(item, e);
            }
            if (((Control)sender).Parent.BackColor != Color.LightBlue)
                tempPanel_MouseEnter(((Control)sender).Parent, e);
            */
        }

        private void tempPanel_MouseLeave(object sender, EventArgs e)
        {
            //if ( ((Control)sender).Tag.ToString() == "main" )
            //    return;
            //((Control)sender).Size -= new Size(10, 10);
            ((Control)sender).BackColor = Color.FromArgb(255,240,240,240);
            /*
             * foreach (Control item in ((Control)sender).Controls)
            {
                if (item.BackColor != Color.FromArgb(255, 240, 240, 240))
                    tempPanel_MouseLeave(item, e);
            }
            if (((Control)sender).Parent.BackColor != Color.FromArgb(255, 240, 240, 240))
                tempPanel_MouseLeave(((Control)sender).Parent, e);
            */
        }
        
    }
}
