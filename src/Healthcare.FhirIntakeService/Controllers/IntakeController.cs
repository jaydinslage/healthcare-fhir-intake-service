using Healthcare.FhirIntakeService.Models;
using Healthcare.FhirIntakeService.Services;
using Microsoft.AspNetCore.Mvc;

namespace Healthcare.FhirIntakeService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IntakeController : ControllerBase
{
    private readonly IIntakeService _intakeService;

    public IntakeController(IIntakeService intakeService)
    {
        _intakeService = intakeService;
    }

    [HttpPost]
    public ActionResult<IntakeResponse> Submit([FromBody] IntakeRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.PatientName))
        {
            return BadRequest(new { message = "PatientName is required." });
        }

        var response = _intakeService.Process(request);
        return Ok(response);
    }
}
