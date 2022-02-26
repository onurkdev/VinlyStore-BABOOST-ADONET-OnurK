using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinlyStore_BABOOST_ADONET_OnurK.Entities;

namespace VinlyStore_BABOOST_ADONET_OnurK.Repo
{
    public class AlbumRepo : BaseRepo, IRepo<Album>
    {
        private Album AlbumMapper(SqlDataReader reader)
        {
            Album album = new Album();
            album.AlbumId = Convert.ToInt32(reader["AlbumId"]);
            album.AlbumName = (reader["Album Name"]).ToString();
            album.GenreId = Convert.ToInt32(reader["GenreId"]);
            album.GenreName = (reader["Genre"]).ToString();
            album.ArtistId = Convert.ToInt32(reader["ArtistId"]);
            album.ArtistName = (reader["Artist Name"]).ToString();
            album.Price = Convert.ToDecimal(reader["Price"]);
            album.Discount = Convert.ToDecimal(reader["Discount"]);
            return album;
        }
        public int Create(Album item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("AlbumName", item.AlbumName);
                command.Parameters.AddWithValue("GenreId", item.GenreId);
                command.Parameters.AddWithValue("ArtistId", item.ArtistId);
                command.Parameters.AddWithValue("Price", item.Price);
                command.Parameters.AddWithValue("Discount", item.Discount);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return returnvalue;
        }

        public int Delete(int id)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("AlbumId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return returnvalue;
        }

        public List<Album> Get()
        {
            List<Album> albums = new List<Album>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_GetAll", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var album = AlbumMapper(reader);
                    albums.Add(album);
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

            return albums;
        }

        public Album GetById(int id)
        {
            Album album = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_GetById", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AlbumId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     album= AlbumMapper(reader);
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
            return album;
        }

        public int Update(Album item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("AlbumId", item.AlbumId);
                command.Parameters.AddWithValue("AlbumName", item.AlbumName);
                command.Parameters.AddWithValue("GenreId", item.GenreId);
                command.Parameters.AddWithValue("ArtistId", item.ArtistId);
                command.Parameters.AddWithValue("Price", item.Price);
                command.Parameters.AddWithValue("Discount", item.Discount);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return returnvalue;
        }

        public List<Album> GetByArtist(int id) {
            List<Album> albums = new List<Album>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_GetByArtist", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ArtistId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var artist = AlbumMapper(reader);
                    albums.Add(artist);
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

            return albums;
        }
        public List<Album> GetByGenre(int id)
        {
            List<Album> albums = new List<Album>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Album_GetByGenre", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GenreId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var artist = AlbumMapper(reader);
                    albums.Add(artist);
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

            return albums;
        }

    }
}
