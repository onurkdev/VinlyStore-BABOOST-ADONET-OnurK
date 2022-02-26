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

    public class ArtistRepo : BaseRepo, IRepo<Artist>
    {
        private Artist ArtistMapper(SqlDataReader reader)
        {
            Artist artist = new Artist();
            artist.ArtistId = Convert.ToInt32(reader["Artist ID"]);
            artist.ArtistName = (reader["Artist Name"]).ToString();
            return artist;
        }
        public int Create(Artist item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Artist_AddUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ArtistName", item.ArtistName);
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
                SqlCommand command = new SqlCommand("Sp_Artist_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ArtistId", id);
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

        public List<Artist> Get()
        {
            List<Artist> artists = new List<Artist>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Artist_GetAll", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var artist = ArtistMapper(reader);
                    artists.Add(artist);
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

            return artists;
        }

        public Artist GetById(int id)
        {
            Artist artist = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Artist_GetById", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ArtistId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    artist = ArtistMapper(reader);
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
            return artist;
        }

        public int Update(Artist item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Artist_AddUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ArtistId", item.ArtistId);
                command.Parameters.AddWithValue("ArtistName", item.ArtistName);
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
    }
}
