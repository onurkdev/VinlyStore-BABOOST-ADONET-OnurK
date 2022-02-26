using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Repo
{
    using System.Data;
    using System.Data.SqlClient;
    using VM;
    public class MainPageRepo:BaseRepo
    {
        private VMTop TopMapper(SqlDataReader reader)
        {
            VMTop top = new VMTop();
            top.AlbumId = Convert.ToInt32(reader["AlbumId"]);
            top.AlbumName = (reader["Album Name"]).ToString();
            top.GenreId = Convert.ToInt32(reader["GenreId"]);
            top.GenreName = (reader["Genre"]).ToString();
            top.ArtistId = Convert.ToInt32(reader["Artistıd"]);
            top.ArtistName = (reader["Artist Name"]).ToString();
            top.Price = Convert.ToDecimal(reader["Price"]);
            top.Discount = Convert.ToDecimal(reader["Discount"]);

            return top;
        }
        private VMBestSellers BestSellerMapper(SqlDataReader reader)
        {
            VMBestSellers best = new VMBestSellers();
            best.AlbumId= Convert.ToInt32(reader["AlbumId"]);
            best.AlbumName = (reader["Album Name"]).ToString();
            best.TotalSales = Convert.ToDecimal(reader["Total Sales"]);
            return best;
        }
        private VMBestSellersWithArtist BestSellersWithArtistMapper (SqlDataReader reader)
        {
            VMBestSellersWithArtist best = new VMBestSellersWithArtist();
            best.AlbumId = Convert.ToInt32(reader["AlbumId"]);
            best.AlbumName = (reader["Album Name"]).ToString();
            best.TotalSale = Convert.ToDecimal(reader["Total Sales"]);
            best.ArtistId = Convert.ToInt32(reader["Artistıd"]);
            best.ArtistName = (reader["Artist Name"]).ToString();
            return best;
        }
        public List<VMTop> Top10() {
            List<VMTop> tops = new List<VMTop>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_MainPage_Top10NewAlbums", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var top = TopMapper(reader);
                    tops.Add(top);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return tops;

        }
        public List<VMTop> Top15D()
        {
            List<VMTop> tops = new List<VMTop>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_MainPage_Discounted15Album", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var top = TopMapper(reader);
                    tops.Add(top);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return tops;

        }

        public List<VMBestSellers> BestSellers()
        {
            List<VMBestSellers> tops = new List<VMBestSellers>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_BestSellers", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var top = BestSellerMapper(reader);
                    tops.Add(top);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return tops;

        }
        public List<VMBestSellersWithArtist> BestSellersWithArtist()
        {
            List<VMBestSellersWithArtist> tops = new List<VMBestSellersWithArtist>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_BestSellersWithArtists", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var top = BestSellersWithArtistMapper(reader);
                    tops.Add(top);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return tops;

        }

    }
}
