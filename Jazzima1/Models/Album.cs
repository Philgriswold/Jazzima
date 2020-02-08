using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public string Image { get; set; }
        public List<MusicianAlbum> MusicianAlbums { get; set; }
      
    }
}
