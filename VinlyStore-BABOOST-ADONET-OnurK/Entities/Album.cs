using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Entities
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public int? GenreId { get; set; }
        public string GenreName { get; set; }
        public int? ArtistId { get; set; }
        public string ArtistName { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }

    }
}
