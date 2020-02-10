using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Jazzima1.Data;
using Jazzima1.Models;
using Microsoft.AspNetCore.Identity;

namespace Jazzima1.Controllers
{
    public class SavedAlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public SavedAlbumsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: SavedAlbums
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SavedAlbums.Include(s => s.Album);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SavedAlbums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savedAlbum = await _context.SavedAlbums
                .Include(s => s.Album)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (savedAlbum == null)
            {
                return NotFound();
            }

            return View(savedAlbum);
        }

        // GET: SavedAlbums/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id");
            return View();
        }

        // POST: SavedAlbums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AlbumId,UserId")] SavedAlbum savedAlbum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(savedAlbum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", savedAlbum.AlbumId);
            return View(savedAlbum);
        }

        // GET: SavedAlbums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savedAlbum = await _context.SavedAlbums.FindAsync(id);
            if (savedAlbum == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", savedAlbum.AlbumId);
            return View(savedAlbum);
        }

        // POST: SavedAlbums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AlbumId,UserId")] SavedAlbum savedAlbum)
        {
            if (id != savedAlbum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(savedAlbum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SavedAlbumExists(savedAlbum.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Album, "Id", "Id", savedAlbum.AlbumId);
            return View(savedAlbum);
        }

        // GET: SavedAlbums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var savedAlbum = await _context.SavedAlbums
                .Include(s => s.Album)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (savedAlbum == null)
            {
                return NotFound();
            }

            return View(savedAlbum);
        }

        // POST: SavedAlbums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var savedAlbum = await _context.SavedAlbums.FindAsync(id);
            _context.SavedAlbums.Remove(savedAlbum);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Albums");
        }

        private bool SavedAlbumExists(int id)
        {
            return _context.SavedAlbums.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
