# Healthcare FHIR Intake Service

A small .NET 8 ASP.NET Core starter service for healthcare intake scenarios. It accepts intake submissions, validates the most important input, and returns a structured acknowledgment.

## What it contains
- A simple API controller for intake submission
- A service layer for processing intake requests
- Plain models for inbound and outbound payloads

## Run locally
```bash
dotnet run --project src/Healthcare.FhirIntakeService
```

## Endpoints

### POST /api/intake
Accepts a JSON intake payload and returns a confirmation response.

#### Example request
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

#### Example response
```json
{
  "requestId": "INT-20260712090000-ABC123",
  "status": "Accepted",
  "message": "Healthcare intake request accepted for Jane Doe.",
  "processedAt": "2026-07-12T09:00:00Z"
}
```

## Project Structure
- src/Healthcare.FhirIntakeService/Controllers/IntakeController.cs - API endpoint handling for the intake submission flow
- src/Healthcare.FhirIntakeService/Services/IntakeService.cs - Request processing and response generation
- src/Healthcare.FhirIntakeService/Models/IntakeRequest.cs - Inbound payload contract
- src/Healthcare.FhirIntakeService/Models/IntakeResponse.cs - Outbound payload contract
- src/Healthcare.FhirIntakeService/Program.cs - Application startup and dependency injection setup
- src/Healthcare.FhirIntakeService/appsettings.json - Shared application configuration
- src/Healthcare.FhirIntakeService/appsettings.Development.json - Development-specific configuration overrides
- src/Healthcare.FhirIntakeService/Properties/launchSettings.json - Local launch settings for debugging and running

## Architecture Overview
The service follows a simple layered flow:
1. The controller receives the POST request.
2. The controller validates the incoming payload.
3. The service creates a structured response for the intake request.
4. The response is returned to the caller as JSON.

This starter project is intentionally minimal and easy to extend for more advanced FHIR-oriented workflows.
