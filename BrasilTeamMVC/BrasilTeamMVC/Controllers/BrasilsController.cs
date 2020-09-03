using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BrasilTeamMVC.Data;
using BrasilTeamMVC.Models;

namespace BrasilTeamMVC.Controllers
{
    public class BrasilsController : Controller
    {
        private readonly BrasilTeamMVCContext _context;

        public BrasilsController(BrasilTeamMVCContext context)
        {
            _context = context;
        }

        // GET: Brasils
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brasil.ToListAsync());
        }

        // GET: Brasils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brasil = await _context.Brasil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brasil == null)
            {
                return NotFound();
            }

            return View(brasil);
        }

        // GET: Brasils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Brasils/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumeroJogador,NomeJogador,PosicaoJogador")] Brasil brasil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brasil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brasil);
        }

        // GET: Brasils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brasil = await _context.Brasil.FindAsync(id);
            if (brasil == null)
            {
                return NotFound();
            }
            return View(brasil);
        }

        // POST: Brasils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumeroJogador,NomeJogador,PosicaoJogador")] Brasil brasil)
        {
            if (id != brasil.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brasil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrasilExists(brasil.Id))
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
            return View(brasil);
        }

        // GET: Brasils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brasil = await _context.Brasil
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brasil == null)
            {
                return NotFound();
            }

            return View(brasil);
        }

        // POST: Brasils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brasil = await _context.Brasil.FindAsync(id);
            _context.Brasil.Remove(brasil);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrasilExists(int id)
        {
            return _context.Brasil.Any(e => e.Id == id);
        }
    }
}
