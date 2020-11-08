using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication
{
    public class DataHelper
    {
        public static List<Koncerti> GetConcerts() {
            List<Koncerti> concerts = new List<Koncerti>();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q3SHU1U; Initial Catalog=Koncerti;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("SELECT ID,CONCERT_NAME, VENUE_NAME, MAX_SEATS, GENRE, DATE_CONCERT FROM dbo.Concerts", con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
          
            while (dr.Read())
            {
                var koncerti = new Koncerti();
                koncerti.concertId = (int)dr.GetValue(0);
                koncerti.concert_Name = dr.GetValue(1).ToString();
                koncerti.venue_Name = dr.GetValue(2).ToString();
                koncerti.max_Seats = (int)dr.GetValue(3);
                koncerti.genre = dr.GetValue(4).ToString();
                koncerti.date_Concert = dr.GetValue(5).ToString();

                concerts.Add(koncerti);
            }
            dr.Close();
            con.Close();

            return concerts;
        }
        public static void UpdateConcerts(int concertId, int tiketi) {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q3SHU1U; Initial Catalog=Koncerti;Integrated Security=true;");
            SqlCommand cmd = new SqlCommand("SELECT MAX_SEATS FROM dbo.Concerts WHERE ID=" +concertId, con);
            con.Open();
            int seats = (int)cmd.ExecuteScalar();
            
            //get max_seats for conncertId and store in variable seats
            seats = seats - tiketi;
            //reduce seats by 1

            //update max_seats
            SqlCommand update = new SqlCommand("UPDATE dbo.Concerts SET MAX_SEATS =" +seats+ " WHERE ID=" +concertId, con);
          
            update.ExecuteNonQuery();
            con.Close();

        }

        
        
    }
}
