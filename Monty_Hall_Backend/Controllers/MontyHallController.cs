using Microsoft.AspNetCore.Mvc;
using Monty_Hall;

[ApiController]
[Route("api/[controller]")]
public class MontyHallController : ControllerBase
{
    private readonly MontyHallSimulation _simulation;

    public MontyHallController()
    {
        _simulation = new MontyHallSimulation();
    }

    [HttpPost("simulate")]
    public ActionResult<int> SimulateGames([FromBody] SimulationRequest request)
    {

        int wins = _simulation.SimulateGames(request.NumSimulations, request.ChangeDoor);
        return wins;
    }
}

public class SimulationRequest
{
    public int NumSimulations { get; set; }
    public bool ChangeDoor { get; set; }
}
