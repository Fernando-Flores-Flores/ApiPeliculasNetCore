using System.ComponentModel.DataAnnotations;
using static ApiPeliculas.Models.Pelicula;


namespace ApiPeliculas.Models.Dtos
{
    public class PeliculaUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        public string RutaImagen { get; set; }


        [Required(ErrorMessage = "La descripciopn  es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La duracion es obligatorio")]
        public string Duracion { get; set; }

        public TipoClasificacion Clasificacion { get; set; }
        public int categoriaId { get; set; }

    }
}
