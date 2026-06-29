namespace WarsawEvents.Domain.DTOs;

/// <summary>
/// Data transfer object for Registration
/// </summary>
public class RegistrationDto
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public string AttendeeEmail { get; set; } = string.Empty;
    public string AttendeeFirstName { get; set; } = string.Empty;
    public string AttendeeLastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
    public bool Attended { get; set; }
    public string? TicketCode { get; set; }
    public string FullName { get; set; } = string.Empty;
}

/// <summary>
/// DTO for creating registrations
/// </summary>
public class CreateRegistrationDto
{
    public int EventId { get; set; }
    public string AttendeeEmail { get; set; } = string.Empty;
    public string AttendeeFirstName { get; set; } = string.Empty;
    public string AttendeeLastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
}
