using Microsoft.AspNetCore.Mvc;
using ViewComponentJuegos.Models;
using ViewComponentJuegos.Repositories;

namespace ViewComponentJuegos.ViewComponents
{
    public class MenuGenerosViewComponent : ViewComponent
    {
        private RepositoryJuegos repo;

        public MenuGenerosViewComponent(RepositoryJuegos repo)
        {
            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Genero> generos = await this.repo.MostrarGenerosAsync();
            return View(generos);
        }
    }
}
