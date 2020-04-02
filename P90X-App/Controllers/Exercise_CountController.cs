using P90X_App.Models;
using P90X_App.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace P90X_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Exercise_CountController : ControllerBase
    {
        private readonly Exercise_CountService _exercise_countService;

        public Exercise_CountController(Exercise_CountService exercise_countService)
        {
            _exercise_countService = exercise_countService;
        }

        [HttpGet]
        public ActionResult<List<Exercise_Count>> Get() =>
            _exercise_countService.Get();

        [HttpGet("{id:length(24)}", Name = "GetExercise")]
        public ActionResult<Exercise_Count> Get(string id)
        {
            var exercise_count = _exercise_countService.Get(id);
            
            if (exercise_count == null)
            {
                return NotFound();
            }

            return exercise_count;
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Exercise_Count exercise_countIn)
        {
            var exercise_count = _exercise_countService.Get(id);

            if (exercise_count == null)
            {
                return NotFound();
            }

            _exercise_countService.Update(id, exercise_countIn);

            return NoContent();
        }

    }
}