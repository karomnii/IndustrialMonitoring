# Industrial Monitoring System

A SCADA-like monitoring system built with ASP.NET Core, designed for industrial sensor data collection and real-time monitoring.

## Features

- RESTful API for sensor data management
- SQL Server database integration using Entity Framework Core
- Clean Architecture implementation
- Real-time data collection capabilities

## Prerequisites

- .NET 7.0 SDK or later
- SQL Server 2019 or later
- Visual Studio 2022 or later

## Project Structure

```
IndustrialMonitoring/
├── IndustrialMonitoring.Api        # Web API layer
├── IndustrialMonitoring.Core       # Domain models and interfaces
├── IndustrialMonitoring.Infrastructure  # Data access and external services
└── IndustrialMonitoring.Tests      # Unit and integration tests
```

## Getting Started

1. Clone the repository
```bash
git clone https://github.com/karomnii/IndustrialMonitoring.git
```

2. Update the connection string in `appsettings.json`

3. Apply database migrations
```bash
dotnet ef database update
```

4. Run the application
```bash
dotnet run --project IndustrialMonitoring.Api
```

5. Open Swagger UI
```
http://localhost:5078/swagger
```

## API Endpoints

- GET `/api/SensorReadings` - Retrieve latest sensor readings
- POST `/api/SensorReadings` - Create new sensor reading

## Future Enhancements

- RabbitMQ integration for real-time data streaming
- Industrial protocol support (Modbus, OPC UA)
- Real-time data visualization
- Authentication and authorization
- Docker support

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](https://choosealicense.com/licenses/mit/)