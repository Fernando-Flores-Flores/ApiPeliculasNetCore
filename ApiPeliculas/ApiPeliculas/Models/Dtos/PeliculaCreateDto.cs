using System.ComponentModel.DataAnnotations;
using static ApiPeliculas.Models.Pelicula;

namespace ApiPeliculas.Models.Dtos
{
    public class PeliculaCreateDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripciopn  es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La duracion es obligatoria")]
        public string Duracion { get; set; }

        [Required]
        public TipoClasificacion Clasificacion { get; set; }

        public int categoriaId { get; set; }
        public string RutaImagen { get; set; }
        public IFormFile Foto { get; set; }
    }
}
