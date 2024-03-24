using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ViewComponentJuegos.Data;
using ViewComponentJuegos.Models;

#region PROCEDIMIENTOS ALMACENADOS

//create procedure SP_FILTRAR_JUEGOS_CATEGORIAS
//(@idgenero int)
//as
//	select * from Juego
//	where Juego.IDGenero=@idgenero
//go

#endregion

namespace ViewComponentJuegos.Repositories
{
    public class RepositoryJuegos
    {
        private VCJuegosContext context;

        public RepositoryJuegos(VCJuegosContext context)
        {
            this.context = context;
        }

        public List<Juego> MostrarJuegosGeneros(int idgenero)
        {
            var consulta = this.context.Juegos.Where(z => z.IDGenero == idgenero).ToList();
            return consulta;
        }

        public List<Juego> MostrarJuegosProcedure(int idgenero)
        {
            string sql = "SP_FILTRAR_JUEGOS_CATEGORIAS @idgenero";
            SqlParameter pamID = new SqlParameter("idgenero", idgenero);
            var consulta = this.context.Juegos.FromSqlRaw(sql, pamID);
            List<Juego> juegos = consulta.ToList();
            return juegos;
        }

        public async Task<List<Genero>> MostrarGenerosAsync()
        {
            return await this.context.Generos.ToListAsync();
        }
    }
}
