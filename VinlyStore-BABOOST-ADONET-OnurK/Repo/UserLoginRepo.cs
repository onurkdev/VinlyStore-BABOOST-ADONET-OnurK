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
    public class UserLoginRepo : BaseRepo
    {
        private User UserMapper(SqlDataReader reader)
        {
            User user = new User();
            user.UserId = Convert.ToInt32(reader["UserId"]);
            user.Email = (reader["Email"]).ToString();
            user.UserPassword = (reader["UserPassword"]).ToString();
            user.Phone = (reader["Phone"]).ToString();
            return user;
        }
        public bool CheckUser(string email)
        {
            bool returnvalue = false;

            try
            {
                SqlCommand command = new SqlCommand("Sp_User_CheckUser", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Email", email);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                returnvalue = Convert.ToBoolean(command.ExecuteScalar());
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
        public User LoginUser(string email, string password)
        {
            User returnvalue = null;

            try
            {
                SqlCommand command = new SqlCommand("Sp_User_PasswordCheck", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Email", email);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = UserMapper(reader);
                    returnvalue = user;
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

            return returnvalue;

        }
        public User RegisterUser(string email, string phone, string firstname, string lastname, string userpassword)
        {
            User user = new User();
            
            user.Email = email;
            user.FirstName = firstname;
            user.LastName = lastname;
            user.UserPassword = userpassword;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Artist_AddUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("FirstName", user.FirstName);
                command.Parameters.AddWithValue("LastName", user.FirstName);
                command.Parameters.AddWithValue("Email", user.Email);
                command.Parameters.AddWithValue("UserPassword", user.UserPassword);
                command.Parameters.AddWithValue("Phone", user.Phone);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                user.UserId = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            



            return user;
        }
    }
}
