using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChamadosTI.Models.Modelo;

namespace ChamadosTI.Controllers
{
    public class SolicitacoesController : Controller
    {
        private readonly Contexto _context;

        public SolicitacoesController(Contexto context)
        {
            _context = context;
        }

        // GET: Solicitacoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.solicitacoesContext.ToListAsync());
        }

        // GET: Solicitacoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacoes = await _context.solicitacoesContext
                .FirstOrDefaultAsync(m => m.id == id);
            if (solicitacoes == null)
            {
                return NotFound();
            }

            return View(solicitacoes);
        }

        // GET: Solicitacoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Solicitacoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Solicitacoes solicitacoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitacoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(solicitacoes);
        }

        // GET: Solicitacoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacoes = await _context.solicitacoesContext.FindAsync(id);
            if (solicitacoes == null)
            {
                return NotFound();
            }
            return View(solicitacoes);
        }

        // POST: Solicitacoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Solicitacoes solicitacoes)
        {
            if (id != solicitacoes.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitacoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitacoesExists(solicitacoes.id))
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
            return View(solicitacoes);
        }

        // GET: Solicitacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitacoes = await _context.solicitacoesContext
                .FirstOrDefaultAsync(m => m.id == id);
            if (solicitacoes == null)
            {
                return NotFound();
            }

            return View(solicitacoes);
        }

        // POST: Solicitacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var solicitacoes = await _context.solicitacoesContext.FindAsync(id);
            _context.solicitacoesContext.Remove(solicitacoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SolicitacoesExists(int id)
        {
            return _context.solicitacoesContext.Any(e => e.id == id);
        }
    }
}
