﻿using ApiPeliculas.Data;
using ApiPeliculas.Models;
using ApiPeliculas.Repository.IRepository;

namespace ApiPeliculas.Repository
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly ApplicationDbContext _bd;

        public PeliculaRepository(ApplicationDbContext bd)
        {
                _bd = bd;
        }

        public bool ActualizarPelicula(Pelicula pelicula)
        {
            _bd.Pelicula.Update(pelicula);
            return Guardar();
        }

        public bool BorrarPelicula(Pelicula pelicula)
        {
            _bd.Pelicula.Remove(pelicula);
            return Guardar();
        }

        public IEnumerable<Pelicula> BuscarPelicula(string nombre)
        {
            IQueryable<Pelicula> query = _bd.Pelicula;
            if (!string.IsNullOrEmpty(nombre)) {
                query = query.Where(e=>e.Nombre.Contains(nombre) || e.Descripcion.Contains(nombre));
            }
            return query.ToList();
        }

        public bool CrearPelicula(Pelicula pelicula)
        {
            _bd.Pelicula.Add(pelicula);
            return Guardar();

        }

        public bool ExistePelicula(string nombre)
        {
            bool valor= _bd.Pelicula.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExistePelicula(int id)
        {
            return _bd.Pelicula.Any(c => c.Id == id);
        }

        public Pelicula GetPelicula(int PeliculaId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pelicula> GetPeliculas()
        {
            throw new NotImplementedException();
        }

        public ICollection<Pelicula> GetPeliculasEnCategoria(int CarId)
        {
            throw new NotImplementedException();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }
    }
}
