using Microsoft.AspNetCore.Mvc;
using Calificaciones.Models;
using Calificaciones.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace Calificaciones.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstudiantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET: Estudiantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estudiante.ToListAsync());
        }

        //GET: Estudiante/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: Estudiantes/Create    
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id, Nombre, Apellidos, TipoDocumento, Documento, Email, Direccion, Telefono, Estado")] Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estudiante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }

        //GET: Estudiante/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FindAsync(id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        //POST: Estudiantes/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nombre, Apellidos, TipoDocumento, Documento, Email, Direccion, Telefono, Estado")] Estudiante estudiante)
        {
            if (id != estudiante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estudiante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstudianteExists(estudiante.Id))
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
            return View(estudiante);
        }


        //GET: Estudiante/Details
        public async Task<IActionResult> Details(int? id)
        {
            if(id== null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        //GET: Estudiante/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if(id== null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            return View(estudiante);
        }

        //POST: Estudiante/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estudiante = await _context.Estudiante.FindAsync(id);
            _context.Estudiante.Remove(estudiante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstudianteExists(int id)
        {
            return _context.Estudiante.Any(e => e.Id == id);
        }
    }
}