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
    public class OrderDetailRepo : BaseRepo, IRepo<OrderDetail>
    {
        private OrderDetail OrderDetailMapper(SqlDataReader reader)
        {
            OrderDetail orderdetail = new OrderDetail();
            orderdetail.OrderDetailId = Convert.ToInt32(reader["OrderDetailId"]);
            orderdetail.OrderId = Convert.ToInt32(reader["OrderId"]);
            orderdetail.AlbumId = Convert.ToInt32(reader["AlbumId"]);
            orderdetail.AlbumName = (reader["Album Name"]).ToString();
            orderdetail.Quantity = Convert.ToInt32(reader["Quantity"]);
            orderdetail.Discount = Convert.ToDecimal(reader["Discount"]);
            orderdetail.ListPrice = Convert.ToDecimal(reader["List Price"]);
            orderdetail.BilledPrice = Convert.ToDecimal(reader["Discounted Price"]);
            orderdetail.GenreId = Convert.ToInt32(reader["GenreId"]);
            orderdetail.GenreName = (reader["Genre"]).ToString();
            orderdetail.ArtistId = Convert.ToInt32(reader["ArtistId"]);
            orderdetail.UnitPrice = Convert.ToDecimal(reader["Unit Price"]);

            return orderdetail;
        }
        public int Create(OrderDetail item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_OrderDetails_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderId", item.OrderId);
                command.Parameters.AddWithValue("AlbumId", item.AlbumId);
                command.Parameters.AddWithValue("Quantity", item.Quantity);
                command.Parameters.AddWithValue("Discount", item.Discount);
                command.Parameters.AddWithValue("ListPrice", item.ListPrice);
                command.Parameters.AddWithValue("BilledPrice", item.BilledPrice);
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
                SqlCommand command = new SqlCommand("Sp_OrderDetail_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderDetailId", id);
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

        public List<OrderDetail> Get()
        {
            List<OrderDetail> orderdetails = new List<OrderDetail>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_OrderDetails_GetAll", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var orderdetail = OrderDetailMapper(reader);
                    orderdetails.Add(orderdetail);
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

            return orderdetails;
        }

        public OrderDetail GetById(int id)
        {
            OrderDetail orderDetail = null;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Orders_GetById", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OrderDetailId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    orderDetail = OrderDetailMapper(reader);
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
            return orderDetail;
        }

        public List<OrderDetail> GetByOrderId(int id)
        {
            List<OrderDetail> orderdetails = new List<OrderDetail>();
            try
            {
                SqlCommand command = new SqlCommand("Sp_OrderDetails_GetAll", this.Connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@OrderId", id);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var orderdetail = OrderDetailMapper(reader);
                    orderdetails.Add(orderdetail);
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

            return orderdetails;
        }

        public int Update(OrderDetail item)
        {
            int returnvalue = 0;

            try
            {
                SqlCommand command = new SqlCommand("Sp_OrderDetails_CreateUpdate", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("OrderDetailId", item.OrderDetailId);
                command.Parameters.AddWithValue("OrderId", item.OrderId);
                command.Parameters.AddWithValue("AlbumId", item.AlbumId);
                command.Parameters.AddWithValue("Quantity", item.Quantity);
                command.Parameters.AddWithValue("Discount", item.Discount);
                command.Parameters.AddWithValue("ListPrice", item.ListPrice);
                command.Parameters.AddWithValue("BilledPrice", item.BilledPrice);
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
