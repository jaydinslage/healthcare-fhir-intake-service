using Healthcare.FhirIntakeService.Models;

namespace Healthcare.FhirIntakeService.Services;

public class IntakeService : IIntakeService
{
    public IntakeResponse Process(IntakeRequest request)
    {
        var requestId = $"INT-{DateTimeOffset.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid().ToString("N")[..6]}";

        return new IntakeResponse
        {
            RequestId = requestId,
            Status = "Accepted",
            Message = $"Healthcare intake request accepted for {request.PatientName}.",
            ProcessedAt = DateTimeOffset.UtcNow
        };
    }
}
