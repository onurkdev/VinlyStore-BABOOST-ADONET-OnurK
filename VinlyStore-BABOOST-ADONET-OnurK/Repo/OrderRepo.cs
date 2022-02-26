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
    public class OrderRepo : BaseRepo, IRepo<Order>
    {
        private Order OrderMapper(SqlDataReader reader)
        {
            Order order = new Order();
            order.OrderId = Convert.ToInt32(reader["OrderId"]);
            order.OrderDate = Convert.ToDateTime(reader["Order Date"]);
            order.Adress = (reader["Adress"]).ToString();
            order.OrderQuantity = Convert.ToInt32(reader["Order Quantity"]);
            order.OrderGrandTotal = Convert.ToDecimal(reader["Grand Total"]);
            order.UserId = Convert.ToInt32(reader["UserId"]);
            order.CreatedBy = (reader["Created By"]).ToString();
            return order;
        }
        public int Create(Order item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Orders_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderDate", item.OrderDate);
                command.Parameters.AddWithValue("Adress", item.Adress);
                command.Parameters.AddWithValue("OrderQuantity", item.OrderQuantity);
                command.Parameters.AddWithValue("OrderGrandTotal", item.OrderGrandTotal);
                command.Parameters.AddWithValue("UserId", item.UserId);
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
                SqlCommand command = new SqlCommand("Sp_Order_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderId", id);
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

        public List<Order> Get()
        {
            List<Order> orders = new List<Order>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_Orders_GetAll", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var order = OrderMapper(reader);
                    orders.Add(order);
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

            return orders;
        }

        public Order GetById(int id)
        {
            Order Order = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Orders_GetById", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AlbumId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Order = OrderMapper(reader);
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
            return Order;
        }

        public int Update(Order item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Orders_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderId", item.OrderId);
                command.Parameters.AddWithValue("OrderDate", item.OrderDate);
                command.Parameters.AddWithValue("Adress", item.Adress);
                command.Parameters.AddWithValue("OrderQuantity", item.OrderQuantity);
                command.Parameters.AddWithValue("OrderGrandTotal", item.OrderGrandTotal);
                command.Parameters.AddWithValue("UserId", item.UserId);
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
