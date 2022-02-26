using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? AlbumId { get; set; }
        public string AlbumName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal? BilledPrice { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderDetail()
        {
            BilledPrice = ListPrice * (1 + Discount);
        }
    }
}
