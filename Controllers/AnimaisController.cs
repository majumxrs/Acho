using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        private readonly IAnimaisRepositorio _animaisRepositorio;

        public AnimaisController(IAnimaisRepositorio animaisRepositorio)
        {
            _animaisRepositorio = animaisRepositorio;
        }

        [HttpGet("GetAllAnimal")]
        public async Task<ActionResult<List<AnimaisModel>>> GetAllAnimal()
        {
            List<AnimaisModel> animais = await _animaisRepositorio.GetAll();
            return Ok(animais);
        }

        [HttpGet("GetAnimalId/{id}")]
        public async Task<ActionResult<AnimaisModel>> GetObservacaoId(int id)
        {
            AnimaisModel animais = await _animaisRepositorio.GetById(id);
            return Ok(animais);
        }

        [HttpPost("CreateAnimal")]
        public async Task<ActionResult<AnimaisModel>> InsertAnimal([FromBody] AnimaisModel animaisModel)
        {
            AnimaisModel animais = await _animaisRepositorio.InsertAnimal(animaisModel);
            return Ok(animais);
        }

        [HttpPut("UpdateAnimal/{id:int}")]
        public async Task<ActionResult<AnimaisModel>> UpdateAnimal(int id, [FromBody] AnimaisModel animaisModel)
        {
            animaisModel.AnimaisId = id;
            AnimaisModel animal = await _animaisRepositorio.UpdateAnimal(animaisModel, id);
            return Ok(animal);
        }
        [HttpDelete("DeleteAnimal/{id:int}")]
        public async Task<ActionResult<AnimaisModel>> DeleteAnimal(int id)
        {
            bool deleted = await _animaisRepositorio.DeleteAnimal(id);
            return Ok(deleted);
        }
    }
}
