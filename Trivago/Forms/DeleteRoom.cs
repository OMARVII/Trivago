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
    public partial class DeleteRoom : Form
    {
        OracleConnection conn;
        string connST = "Data Source=ORCL;User Id=HR;Password=hr;";
        public DeleteRoom()
        {
            InitializeComponent();
            conn = new OracleConnection(connST);
            conn.Open();
            init();
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

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
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
    }
}
