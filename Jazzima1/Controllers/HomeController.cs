using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jazzima1.Models;
using Jazzima1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Jazzima1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Jazzima1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            MusicianAlbumViewModel MAviewModel = new MusicianAlbumViewModel();
            //first instantiating my view model
            //second get instrumetns that correspond to the same instrumenttype
            //third put those players of an instrumenttype into a list
            //fourth put return view - lists into corresponding view model

            // HORN PLAYERS

            var hornPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(1));

            List<SelectListItem> hornList = new List<SelectListItem>();
            SelectListItem nullHornListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            hornList.Add(nullHornListItem);
            foreach (var h in hornPlayerDB)
            {
                SelectListItem hornListItem = new SelectListItem
                {
                    Value = h.Id.ToString(),
                    Text = h.Name
                };
                hornList.Add(hornListItem);
            }

            MAviewModel.HornPlayers = hornList;


            //PIANO PLAYERS--------------------------------------------------------------------------------

            var pianoPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(2));

            List<SelectListItem> pianoList = new List<SelectListItem>();
            SelectListItem nullPianoListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            pianoList.Add(nullPianoListItem);

            foreach (var p in pianoPlayerDB)
            {
                SelectListItem pianoListItem = new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                };
                pianoList.Add(pianoListItem);
            }

            MAviewModel.PianoPlayers = pianoList;


            //BASS PLAYERS----------------------------------------------------------------------------------

            var bassPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(3));

            List<SelectListItem> bassList = new List<SelectListItem>();
            SelectListItem nullBassListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            bassList.Add(nullBassListItem);
            foreach (var b in bassPlayerDB)
            {
                SelectListItem bassListItem = new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                };
                bassList.Add(bassListItem);
            }

            MAviewModel.BassPlayers = bassList;



            //DRUM PLAYERS------------------------------------------------------------------------------------

            var drumPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(4));

            List<SelectListItem> drumList = new List<SelectListItem>();
            SelectListItem nullDrumListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            drumList.Add(nullDrumListItem);
            foreach (var d in drumPlayerDB)
            {
                SelectListItem drumListItem = new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name
                };
                drumList.Add(drumListItem);
            }

            MAviewModel.DrumPlayers = drumList;





            //var pianoPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(2));

            //List<SelectListItem> pianoList = new List<SelectListItem>();
            //foreach (var p in pianoPlayerDB)
            //{
            //    SelectListItem pianoListItem = new SelectListItem
            //    {
            //        Value = p.Id.ToString(),
            //        Text = p.Name
            //    };
            //    hornList.Add(pianoListItem);
            //}
            //MAviewModel.PianoPlayers = pianoList;

            //var bassPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(3));

            //List<SelectListItem> bassList = new List<SelectListItem>();
            //foreach (var b in bassPlayerDB)
            //{
            //    SelectListItem bassListItem = new SelectListItem
            //    {
            //        Value = b.Id.ToString(),
            //        Text = b.Name
            //    };
            //    bassList.Add(bassListItem);
            //}
            //MAviewModel.BassPlayers = bassList;

            //var drumPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(4));

            //List<SelectListItem> drumList = new List<SelectListItem>();
            //foreach (var d in drumPlayerDB)
            //{
            //    SelectListItem drumListItem = new SelectListItem
            //    {
            //        Value = d.Id.ToString(),
            //        Text = d.Name
            //    };
            //    hornList.Add(drumListItem);
            //}
            //MAviewModel.DrumPlayers = drumList;

            ////var Musicians = new selectList.Musician( "Id", "Name");

            //var user = await GetCurrentUserAsync();
            var AlbumDb = _context.Album;
            // .FirstOrDefaultAsync(m => m.Id == id);
            return View(MAviewModel);


            //  .Where(p => p.City.Equals(search));

            //context.musicianswhere(instrumenttype is 1
            // var applicationDbContext = _context.Product

            //.Include(p => p.OrderProducts)

            //.Where(p => p.UserId == user.Id);

            //context.musicianswhere(instrumenttype is 2

            //then select statement for each of those, where followed by select.. where comes first, select takes raw data and converts into something for view

            // VAR MUSICIANS = new selectList(Musicians, "Id", "Name)
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(MusicianAlbumViewModel musicianAlbumViewModel)
        {

            MusicianAlbumViewModel vm = new MusicianAlbumViewModel()
            {

                HornPlayers = new List<SelectListItem>(),
                PianoPlayers = new List<SelectListItem>(),
                BassPlayers = new List<SelectListItem>(),
                DrumPlayers = new List<SelectListItem>(),
            };

            //if(musicianAlbumViewModel.HornId > 0 && musicianAlbumViewModel.HornPlayers != null || 
            //    musicianAlbumViewModel.PianoId > 0 && musicianAlbumViewModel.PianoPlayers != null || 
            //    musicianAlbumViewModel.BassId > 0 && musicianAlbumViewModel.BassPlayers != null ||
            //    musicianAlbumViewModel.DrumId > 0 && musicianAlbumViewModel.DrumPlayers != null)
            //{
            //    //search for
            //}

            var query = _context.Album.Include(m => m.MusicianAlbums).ThenInclude(a => a.Album).AsQueryable();

            if (musicianAlbumViewModel.HornId > 0)
            {
                query = query.Where(a => a.MusicianAlbums.Any(m => m.MusicianId == musicianAlbumViewModel.HornId));
            }
            if (musicianAlbumViewModel.PianoId > 0)
            {
                query = query.Where(a => a.MusicianAlbums.Any(m => m.MusicianId == musicianAlbumViewModel.PianoId));
            }
            if (musicianAlbumViewModel.BassId > 0)
            {
                query = query.Where(a => a.MusicianAlbums.Any(m => m.MusicianId == musicianAlbumViewModel.BassId));
            }
            if (musicianAlbumViewModel.DrumId > 0)
            {
                query = query.Where(a => a.MusicianAlbums.Any(m => m.MusicianId == musicianAlbumViewModel.DrumId));
            }

            vm.MatchingAlbums = query.ToList();


            //var query2 = _context.Album.Include(m => m.MusicianAlbums).ThenInclude(a => a.Album).AsQueryable();

            //if (musicianAlbumViewModel.HornId > 0)
            //{
            //    query2 = null;
            //}
            //if (musicianAlbumViewModel.PianoId > 0)
            //{
            //    query2 = null;
            //}
            //if (musicianAlbumViewModel.BassId > 0)
            //{
            //    query2 = null;
            //}
            //if (musicianAlbumViewModel.DrumId > 0)
            //{
            //    query2 = null;
            //}

            //vm.MatchingAlbums = query2.ToList();






            var hornPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(1));

            List<SelectListItem> hornList = new List<SelectListItem>();

            SelectListItem nullHornListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            hornList.Add(nullHornListItem);

            foreach (var h in hornPlayerDB)
            {
                SelectListItem hornListItem = new SelectListItem
                {
                    Value = h.Id.ToString(),
                    Text = h.Name
                };
                hornList.Add(hornListItem);
            }

            vm.HornPlayers = hornList;


            //PIANO PLAYERS--------------------------------------------------------------------------------

            var pianoPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(2));

            List<SelectListItem> pianoList = new List<SelectListItem>();
            SelectListItem nullPianoListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            pianoList.Add(nullPianoListItem);
            foreach (var p in pianoPlayerDB)
            {
                SelectListItem pianoListItem = new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                };
                pianoList.Add(pianoListItem);
            }

            vm.PianoPlayers = pianoList;


            //BASS PLAYERS----------------------------------------------------------------------------------

            var bassPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(3));

            List<SelectListItem> bassList = new List<SelectListItem>();
            SelectListItem nullBassListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            bassList.Add(nullBassListItem);
            foreach (var b in bassPlayerDB)
            {
                SelectListItem bassListItem = new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                };
                bassList.Add(bassListItem);
            }

            vm.BassPlayers = bassList;



            //DRUM PLAYERS------------------------------------------------------------------------------------

            var drumPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(4));

            List<SelectListItem> drumList = new List<SelectListItem>();
            SelectListItem nullDrumListItem = new SelectListItem
            {
                Value = "0",
                Selected = true,
                Text = "",
            };
            drumList.Add(nullDrumListItem);
            foreach (var d in drumPlayerDB)
            {
                SelectListItem drumListItem = new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name
                };
                drumList.Add(drumListItem);
            }
            vm.DrumPlayers = drumList;

            return View(vm);
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await GetCurrentUserAsync();
            var album = await _context.Album
                .FirstOrDefaultAsync(m => m.Id == id);

            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
