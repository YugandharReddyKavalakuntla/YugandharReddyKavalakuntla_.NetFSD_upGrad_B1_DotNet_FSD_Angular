using FlightAPI.Model;
using FlightAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlightAPI.controller{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase{
        private readonly FlightRepository _repository;

        public FlightController(FlightRepository flightRepository){
            this._repository = flightRepository;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll(){
            return Ok(_repository.GetFlights());
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(int id){
            return Ok(_repository.GetFlight(id));
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] Flight flight)
        {
            _repository.AddFlight(flight);
            return Ok("Flight Added");
        }

        [HttpPut("Edit")]
        public IActionResult Edit([FromBody] Flight flight)
        {
            _repository.EditFlight(flight);
            return Ok("Flight Updated");
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _repository.DeleteFlight(id);
            return Ok("Flight Deleted");
        }

    }
}