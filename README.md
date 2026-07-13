# Healthcare FHIR Intake Service

A small .NET 8 ASP.NET Core starter service for healthcare intake scenarios.

## What it contains
- A simple API controller for intake submission
- A service layer for processing intake requests
- Plain models for inbound and outbound payloads

## Run locally
```bash
dotnet run --project src/Healthcare.FhirIntakeService
```

## Example request
```bash
curl -X POST https://localhost:5001/api/intake \
  -H "Content-Type: application/json" \
  -d '{
    "patientName": "Jane Doe",
    "patientId": "12345",
    "encounterType": "initial",
    "sourceSystem": "portal",
    "metadata": {
      "priority": "routine"
    }
  }'
```
