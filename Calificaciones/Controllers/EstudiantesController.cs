using Microsoft.AspNetCore.Mvc;
using Calificaciones.Models;
using Calificaciones.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Calificaciones.Controllers
{
    public class EstudiantesController: Controller
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
    }
}