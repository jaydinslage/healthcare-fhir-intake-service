namespace Healthcare.FhirIntakeService.Models;

public class IntakeRequest
{
    public string PatientName { get; set; } = string.Empty;
    public string? PatientId { get; set; }
    public string? EncounterType { get; set; }
    public string? SourceSystem { get; set; }
    public DateTimeOffset ReceivedAt { get; set; } = DateTimeOffset.UtcNow;
    public Dictionary<string, string> Metadata { get; set; } = new();
}
