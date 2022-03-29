using ApiPeliculas.Models.Dtos;
using ApiPeliculas.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPeliculas.Controllers
{
    //[Route("api/[controller]")]

    [Route("api/Categorias")]
    [ApiController]
    public class CategoriasController : Controller
    {
        private readonly ICategoriaRepository _ctRepo;
        private readonly IMapper _mapper;
        public CategoriasController(ICategoriaRepository ctRepo,IMapper mapper)
        {
            _ctRepo = ctRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategorias() {
            var listaCategorias = _ctRepo.GetCategorias();
            var listaCategotiasDto = new List<CategoriaDto>();
            foreach (var lista in listaCategorias) {
                listaCategotiasDto.Add(_mapper.Map<CategoriaDto>(lista));
            }
            
            
            return Ok(listaCategotiasDto);
        }


    }
}
