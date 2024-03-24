using Microsoft.AspNetCore.Mvc;
using ViewComponentJuegos.Models;
using ViewComponentJuegos.Repositories;

namespace ViewComponentJuegos.Controllers
{
    public class JuegosController : Controller
    {
        private RepositoryJuegos repo;

        public JuegosController(RepositoryJuegos repo)
        {
            this.repo = repo;
        }

        public IActionResult Juegos(int idgenero)
        {
            List<Juego> juegos = this.repo.MostrarJuegosGeneros(idgenero);
            return View(juegos);
        }
    }
}
