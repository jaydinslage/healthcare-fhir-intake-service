using Healthcare.FhirIntakeService.Models;

namespace Healthcare.FhirIntakeService.Services;

public interface IIntakeService
{
    IntakeResponse Process(IntakeRequest request);
}
