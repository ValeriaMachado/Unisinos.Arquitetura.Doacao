using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelpSVP.Data;
using HelpSVP.Models;

namespace HelpSVP.Controllers
{
    public class MoradorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoradorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Moradors
        public async Task<IActionResult> Index()
        {
            var teste = _context.Morador;

            return View(await _context.Morador.ToListAsync());
        }

        // GET: Moradors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // GET: Moradors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Moradors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Naturalidade,Pais,UF,Endereco,Complemento,ContatoEmergencia,TelefoneEmergencia,DoencaAlergica,Valor,DataHoraCadastro")] Morador morador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(morador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(morador);
        }

        // GET: Moradors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador.FindAsync(id);
            if (morador == null)
            {
                return NotFound();
            }
            return View(morador);
        }

        // POST: Moradors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Naturalidade,Pais,UF,Endereco,Complemento,ContatoEmergencia,TelefoneEmergencia,DoencaAlergica,Valor,DataHoraCadastro")] Morador morador)
        {
            if (id != morador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(morador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoradorExists(morador.Id))
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
            return View(morador);
        }

        // GET: Moradors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var morador = await _context.Morador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (morador == null)
            {
                return NotFound();
            }

            return View(morador);
        }

        // POST: Moradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var morador = await _context.Morador.FindAsync(id);
            _context.Morador.Remove(morador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoradorExists(int id)
        {
            return _context.Morador.Any(e => e.Id == id);
        }
    }
}
