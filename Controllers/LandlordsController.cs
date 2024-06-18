﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadvancedOpdracht.Data;
using CadvancedOpdracht.Models;

namespace CadvancedOpdracht.Controllers
{
    public class LandlordsController : Controller
    {
        private readonly CadvancedOpdrachtContext _context;

        public LandlordsController(CadvancedOpdrachtContext context)
        {
            _context = context;
        }

        // GET: Landlords
        public async Task<IActionResult> Index()
        {
            var cadvancedOpdrachtContext = _context.Landlords.Include(l => l.Avatar);
            return View(await cadvancedOpdrachtContext.ToListAsync());
        }

        // GET: Landlords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlord = await _context.Landlords
                .Include(l => l.Avatar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (landlord == null)
            {
                return NotFound();
            }

            return View(landlord);
        }

        // GET: Landlords/Create
        public IActionResult Create()
        {
            ViewData["AvatarId"] = new SelectList(_context.Images, "Id", "Id");
            return View();
        }

        // POST: Landlords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Age,AvatarId")] Landlord landlord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landlord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AvatarId"] = new SelectList(_context.Images, "Id", "Id", landlord.AvatarId);
            return View(landlord);
        }

        // GET: Landlords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlord = await _context.Landlords.FindAsync(id);
            if (landlord == null)
            {
                return NotFound();
            }
            ViewData["AvatarId"] = new SelectList(_context.Images, "Id", "Id", landlord.AvatarId);
            return View(landlord);
        }

        // POST: Landlords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Age,AvatarId")] Landlord landlord)
        {
            if (id != landlord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landlord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LandlordExists(landlord.Id))
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
            ViewData["AvatarId"] = new SelectList(_context.Images, "Id", "Id", landlord.AvatarId);
            return View(landlord);
        }

        // GET: Landlords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landlord = await _context.Landlords
                .Include(l => l.Avatar)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (landlord == null)
            {
                return NotFound();
            }

            return View(landlord);
        }

        // POST: Landlords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landlord = await _context.Landlords.FindAsync(id);
            if (landlord != null)
            {
                _context.Landlords.Remove(landlord);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LandlordExists(int id)
        {
            return _context.Landlords.Any(e => e.Id == id);
        }
    }
}
