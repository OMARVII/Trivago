using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Trivago.Classes
{
    static class HelperClass
    {
        public static string getRoomType(int RoomID,int HotelID, OracleConnection conn)
        {
            OracleCommand getRoomID = new OracleCommand();
            getRoomID.Connection = conn;
            getRoomID.CommandText = "select type from room where id = :RoomID and hotel_id = :HotelID";
            getRoomID.CommandType = CommandType.Text;
            getRoomID.Parameters.Add("RoomID", RoomID);
            getRoomID.Parameters.Add("HotelID", HotelID);
            OracleDataReader datareader = getRoomID.ExecuteReader();
            if (datareader.Read())
            {
                return datareader[0].ToString();
            }
            return null;
        }
        public static bool ValidEmail(string Email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch
            {
                return false;
            }
        }
        
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public static bool ValidRating(int HotelRating)
        {
            if (HotelRating > 0 && HotelRating <= 5)
                return true;
            else return false;
        }
        public static  bool ValidPhoneNumber(string Number)
        {
            if (HelperClass.IsDigitsOnly(Number) && Number.Length == 12)
            {
                return true;
            }
            return false;
        }
        public static int getHotelID(string HotelName, OracleConnection conn)
        {
            OracleCommand getHotelID = new OracleCommand();
            getHotelID.Connection = conn;
            getHotelID.CommandText = " select id from hotel where name = :HotelName";
            getHotelID.CommandType = CommandType.Text;
            getHotelID.Parameters.Add("HotelName", HotelName);
            OracleDataReader datareader = getHotelID.ExecuteReader();
            if (datareader.Read())
            {
                return Convert.ToInt32(datareader[0]);
            }
            return -1;
        }
    }
}
