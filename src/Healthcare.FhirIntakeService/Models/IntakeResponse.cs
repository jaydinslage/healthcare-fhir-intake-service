namespace Healthcare.FhirIntakeService.Models;

public class IntakeResponse
{
    public string RequestId { get; init; } = string.Empty;
    public string Status { get; init; } = "Accepted";
    public string Message { get; init; } = "Intake request received.";
    public DateTimeOffset ProcessedAt { get; init; } = DateTimeOffset.UtcNow;
}
