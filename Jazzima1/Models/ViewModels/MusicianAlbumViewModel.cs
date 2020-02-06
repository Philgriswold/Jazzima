using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models.ViewModels
{
    public class MusicianAlbumViewModel
    {
        //thiese are the ones the user slects
        public int HornId { get; set; }
        public int PianoId { get; set; }
        public int BassId { get; set; }
        public int DrumId { get; set; }
        //these are the ones we show
        public List<Musician> HornPlayers { get; set; }
        public List<SelectListItem> HornPlayersSelect { get; set; }

        public List<SelectListItem> PianoPlayers { get; set; }
        public List<SelectListItem> PianoPlayersSelect { get; set; }
        public List<SelectListItem> BassPlayers { get; set; }
        public List<SelectListItem> BassPlayersSelect { get; set; }
        public List<SelectListItem> DrumPlayers { get; set; }
        public List<SelectListItem> DrumPlayersSelect { get; set; }
        public List<Album> MatchingAlbums { get; set; }

    }
}
