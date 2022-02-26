using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Adress { get; set; }
        public List<OrderDetail> OrderDetailList { get; set; }
        public int? OrderQuantity { get; set; }
        public decimal? OrderGrandTotal { get; set; }
        public int? UserId { get; set; }
        public string CreatedBy { get; set; }
    }
}
