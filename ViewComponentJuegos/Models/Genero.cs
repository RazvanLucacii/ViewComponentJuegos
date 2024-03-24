using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ViewComponentJuegos.Models
{
    [Table("Genero")]
    public class Genero
    {
        [Key]
        [Column("IDGenero")]
        public int IdGenero { get; set; }
        [Column("NombreGenero")]
        public string NombreGenero { get; set; }
    }
}
