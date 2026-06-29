# Warsaw Events Copilot

A modern C# web application for managing and displaying Warsaw tech events. Built with ASP.NET Core, Blazor, and Entity Framework Core.

## Features

- **Event Listings**: Browse and discover upcoming Warsaw tech events
- **Event Details**: View comprehensive event information (date, location, speakers, agenda)
- **User Registration**: Register for events and manage tickets
- **Admin Dashboard**: Create, edit, and manage events
- **Responsive Design**: Mobile-first UI with Blazor components
- **RESTful API**: Backend API for all operations
- **Database**: SQL Server with Entity Framework Core

## Tech Stack

- **Backend**: ASP.NET Core 8.0
- **Frontend**: Blazor WebAssembly / Razor Pages
- **Database**: SQL Server / SQLite
- **ORM**: Entity Framework Core
- **API**: RESTful with OpenAPI/Swagger

## Project Structure

```
src/
├── WarsawEvents.Api/              # ASP.NET Core API
│   ├── Controllers/               # API endpoints
│   ├── Services/                  # Business logic
│   ├── Models/                    # Data models
│   └── Program.cs                 # Application startup
├── WarsawEvents.Data/             # Data access layer
│   ├── DbContext/                 # Entity Framework context
│   ├── Migrations/                # Database migrations
│   └── Repositories/              # Data repositories
├── WarsawEvents.Domain/           # Domain models
│   ├── Entities/                  # Business entities
│   └── DTOs/                      # Data transfer objects
└── WarsawEvents.Web/              # Blazor UI components
    ├── Pages/                     # Blazor pages
    ├── Components/                # Reusable components
    └── Services/                  # HTTP client services

## Getting Started

### Prerequisites
- .NET 8.0 SDK
- SQL Server (or SQLite for development)
- Visual Studio 2022 or VS Code

### Setup

1. Clone the repository:
```bash
git clone https://github.com/ossysek/warsaw-events-copilot.git
cd warsaw-events-copilot
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Update database connection in `appsettings.json`

4. Apply migrations:
```bash
dotnet ef database update --project src/WarsawEvents.Data
```

5. Run the application:
```bash
dotnet run --project src/WarsawEvents.Api
```

6. Open browser: `http://localhost:5000`

## API Endpoints

- `GET /api/events` - List all events
- `GET /api/events/{id}` - Get event details
- `POST /api/events` - Create event (admin)
- `PUT /api/events/{id}` - Update event (admin)
- `DELETE /api/events/{id}` - Delete event (admin)
- `POST /api/registrations` - Register for event
- `GET /api/registrations/{eventId}` - Get event registrations

## Development

Build the project:
```bash
dotnet build
```

Run tests:
```bash
dotnet test
```

## License

MIT
