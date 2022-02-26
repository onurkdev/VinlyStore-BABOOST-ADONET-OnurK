using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinlyStore_BABOOST_ADONET_OnurK.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }

        public List<Album> Albums { get; set; }

        public Artist()
        {
            Albums = new List<Album>();
        }
    }
}
