﻿using System;
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
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public AlbumsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Albums
        [HttpGet]
        public async Task<IActionResult> Index(string searchQuery)
        {
            var user = await GetCurrentUserAsync();
            ViewData["CurrentFilter"] = searchQuery;
            if (!String.IsNullOrEmpty(searchQuery))
            {
                var searchedAlbumDb = _context.SavedAlbums.Where(a => a.UserId == user.Id)
                   .Include(c => c.Album) 
                   .ThenInclude(album => album.MusicianAlbums)
                   .ThenInclude(musicianAlbum => musicianAlbum.Musician)
                   .AsQueryable();
                var resultsAlbumDb = await searchedAlbumDb.Where(a => a.Album.MusicianAlbums.Any(m => m.Musician.Name.Contains(searchQuery))).ToListAsync();
                return View(resultsAlbumDb);
            }
            var AlbumDb = _context.SavedAlbums.Where(a => a.UserId == user.Id)
                .Include(c => c.Album);
            //.FirstOrDefaultAsync(m => m.Id == id);
            return View(await AlbumDb.ToListAsync());

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
                .Include(b => b.Comments)
                .ThenInclude(b => b.ApplicationUser)
                .Include(m => m.MusicianAlbums)
                .ThenInclude(m => m.Musician)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // GET: Albums/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Books/Create
        //public async Task<IActionResult> Create()
        //{
        //    var user = await GetCurrentUserAsync();
        //    var authors = _context.Author.Where(a => a.ApplicationUserId == user.Id);
        //    ViewData["AuthorId"] = new SelectList(authors, "Id", "Name");
        //    return View();
        //}

        //// POST: Books/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,AuthorId,YearPublished,Rating,ApplicationUserId,Genre")] Book book)
        //{
        //    var user = await GetCurrentUserAsync();
        //    book.ApplicationUserId = user.Id;

        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(book);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AuthorId"] = new SelectList(_context.Author, "Id", "Name", book.AuthorId);
        //    return View(book);
        //}

        //// GET: Books/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var user = await GetCurrentUserAsync();

        //    var book = await _context.Book.FindAsync(id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AuthorId"] = new SelectList(_context.Author.Where(a => a.ApplicationUserId == user.Id), "Id", "Name", book.AuthorId);
        //    return View(book);
        //}

        // POST: Albums/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Image")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            } 
            return View(album);
        }

        // GET: Albums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var album = await _context.Album.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Image")] Album album)
        {
            if (id != album.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.Id))
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
            return View(album);
        }

        // GET: Albums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await GetCurrentUserAsync();
            var album = await _context.SavedAlbums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var album = await _context.Album.FindAsync(id);
            _context.Album.Remove(album);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
            return _context.Album.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}
