using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models.ViewModels
{
    public class MusicianAlbumViewModel
    {
        public int HornId { get; set; }
        public int PianoId { get; set; }
        public int BassId { get; set; }
        public int DrumId { get; set; }
        public SelectList HornPlayers { get; set; }
        public SelectList PianoPlayers { get; set; }
        public SelectList BassPlayers { get; set; }
        public SelectList Drummers { get; set; }
        public List<Album> MatchingAlbums { get; set; }

    }
}
