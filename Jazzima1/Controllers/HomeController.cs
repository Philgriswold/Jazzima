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
           foreach (var h in hornPlayerDB)
            {
                SelectListItem hornListItem = new SelectListItem
                {
                    Value = h.Id.ToString(),
                    Text = h.Name
                };
                hornList.Add(hornListItem);           
            }
         // MAviewModel.HornPlayers = hornList;

           ViewBag.HornPlayers = hornPlayerDB;
            ViewBag.HornGuys = hornList;

            var hornSelectList = new SelectList(hornList);

            MAviewModel.HornPlayersSelect = hornList;

            ViewBag.HornPlayerList = hornSelectList;


            //PIANO PLAYERS--------------------------------------------------------------------------------
            var pianoPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(2));

            List<SelectListItem> pianoList = new List<SelectListItem>();
            foreach (var p in pianoPlayerDB)
            {
                SelectListItem pianoListItem = new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                };
                pianoList.Add(pianoListItem);
            }
            // MAviewModel.PianoPlayers = pianoList;

            ViewBag.PianoPlayers = pianoPlayerDB;
            ViewBag.PianoGuys = pianoList;

            var pianoSelectList = new SelectList(pianoList);

            MAviewModel.PianoPlayersSelect = pianoList;

            ViewBag.PianoPlayerList = pianoSelectList;

            //BASS PLAYERS----------------------------------------------------------------------------------
            var bassPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(3));

            List<SelectListItem> bassList = new List<SelectListItem>();
            foreach (var b in bassPlayerDB)
            {
                SelectListItem bassListItem = new SelectListItem
                {
                    Value = b.Id.ToString(),
                    Text = b.Name
                };
                bassList.Add(bassListItem);
            }
            // MAviewModel.BassPlayers = bassList;

            ViewBag.BassPlayers = bassPlayerDB;
            ViewBag.BassGuys = bassList;

            var bassSelectList = new SelectList(bassList);

            MAviewModel.BassPlayersSelect = bassList;

            ViewBag.BassPlayerList = bassSelectList;

            //DRUM PLAYERS------------------------------------------------------------------------------------
            var drumPlayerDB = _context.Musician.Where(i => i.InstrumentTypeId.Equals(4));

            List<SelectListItem> drumList = new List<SelectListItem>();
            foreach (var d in drumPlayerDB)
            {
                SelectListItem drumListItem = new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name
                };
                drumList.Add(drumListItem);
            }
            // MAviewModel.DrumPlayers = drumList;

            ViewBag.DrumPlayers = drumPlayerDB;
            ViewBag.DrumGuys = drumList;

            var drumSelectList = new SelectList(drumList);

            MAviewModel.DrumPlayersSelect = drumList;

            ViewBag.DrumPlayerList = drumSelectList;




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

            var user = await GetCurrentUserAsync();
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
