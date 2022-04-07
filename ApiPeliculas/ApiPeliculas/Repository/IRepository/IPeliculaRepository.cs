using ApiPeliculas.Models;

namespace ApiPeliculas.Repository.IRepository
{
    public interface IPeliculaRepository
    {
        //Aqui se guardan los metodos del modelo , en este caso Pelicula
        ICollection<Pelicula> GetPeliculas();
        ICollection<Pelicula> GetPeliculasEnCategoria(int CarId);

        Pelicula GetPelicula (int PeliculaId);

        IEnumerable<Pelicula> BuscarPelicula(string nombre);

        bool ExistePelicula(string nombre);

        bool ExistePelicula(int id);

        bool CrearPelicula(Pelicula pelicula);

        bool ActualizarPelicula(Pelicula pelicula);

        bool BorrarPelicula(Pelicula pelicula);

        bool Guardar();








    }
}
