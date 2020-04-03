using P90X_App.Models;
using P90X_App.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace P90X_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly ExerciseService _exerciseService;

        public ExerciseController(ExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [HttpGet]
        public ActionResult<List<Exercise>> Get() =>
            _exerciseService.Get();

        [HttpGet("{id:length(24)}", Name = "GetExercise")]
        public ActionResult<Exercise> Get(string id)
        {
            var exercise = _exerciseService.Get(id);
            

            if (exercise == null)
            {
                return NotFound();
            }

            return exercise;
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Exercise exerciseIn)
        {
            var exercise = _exerciseService.Get(id);

            if (exercise == null)
            {
                return NotFound();
            }

            _exerciseService.Update(id, exerciseIn);

            return NoContent();
        }

    }
}