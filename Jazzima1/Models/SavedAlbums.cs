using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models
{
    public class SavedAlbums
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string UserId { get; set; }
    }
}
