﻿using System;
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
    public partial class UserFeedback : Form
    {
        OracleConnection FeedBackConnection;
        string ordb = "Data Source=orcl;User Id=HR;Password=HR;";
        public UserFeedback()
        {
            InitializeComponent();
        }

        private void UserFeedback_Load(object sender, EventArgs e)
        {
            FeedBackDate.Text = DateTime.Now.ToShortDateString();
            FeedBackConnection = new OracleConnection(ordb);
            FeedBackConnection.Open();
            FillHotelNames();
        }
        private void FillHotelNames()
        {
            OracleCommand getHotelNames = new OracleCommand();
            getHotelNames.Connection = FeedBackConnection;
            getHotelNames.CommandText = "GETHOTELNAMES";
            getHotelNames.CommandType = CommandType.StoredProcedure;
            getHotelNames.Parameters.Add("HotelNames", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader datareader = getHotelNames.ExecuteReader();
            while (datareader.Read())
            {
                HotelNames.Items.Add(datareader[0].ToString());
            }
            datareader.Close();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                int FeedBack_ID = generateNewFeedBackID();
                int HotelID = HelperClass.getHotelID(HotelNames.SelectedItem.ToString(), FeedBackConnection);
                int user_id = Convert.ToInt32(Login.userID);
                AddFeedBack(FeedBack_ID,user_id,HotelID);
                MessageBox.Show("Submitted FeedBack Successfully :)");
            }
            else
                MessageBox.Show("Check Errors :(");

        }
        private bool ValidInput()
        {
            if (HotelNames.SelectedIndex == -1)
            {
                return false;
            }
            if (FeedbackText.Text == "")
                return false;
            return true;
        }
        private void AddFeedBack(int FeedBack_ID , int User_ID,int Hotel_ID)
        {
            OracleCommand AddFeedBack = new OracleCommand();
            AddFeedBack.Connection = FeedBackConnection;
            AddFeedBack.CommandText = "AddFeedBack";
            AddFeedBack.CommandType = CommandType.StoredProcedure;
            AddFeedBack.Parameters.Add("FeedBack_ID", FeedBack_ID);
            AddFeedBack.Parameters.Add("User_ID", User_ID);
            AddFeedBack.Parameters.Add("FeedBack_text", FeedbackText.Text);
            AddFeedBack.Parameters.Add("FeedBack_Date", Convert.ToDateTime(FeedBackDate.Text));
            AddFeedBack.Parameters.Add("Hotel_ID", Hotel_ID);
            AddFeedBack.ExecuteNonQuery();
        }
        private int generateNewFeedBackID()
        {
            int FeedBackID;
            OracleCommand getFeedbackIDCmd = new OracleCommand();
            getFeedbackIDCmd.Connection = FeedBackConnection;
            getFeedbackIDCmd.CommandText = "generateFeedbackID";
            getFeedbackIDCmd.CommandType = CommandType.StoredProcedure;
            getFeedbackIDCmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            getFeedbackIDCmd.ExecuteNonQuery();
            try
            {
                FeedBackID = Convert.ToInt32(getFeedbackIDCmd.Parameters["id"].Value.ToString());
                FeedBackID += 1;
            }
            catch
            {
                FeedBackID = 1;
            }
            return FeedBackID;
        }
    }
}
