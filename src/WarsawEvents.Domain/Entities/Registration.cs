namespace WarsawEvents.Domain.Entities;

/// <summary>
/// Represents a user registration for an event
/// </summary>
public class Registration
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

    /// <summary>
    /// Full name of the attendee
    /// </summary>
    public string FullName => $"{AttendeeFirstName} {AttendeeLastName}";
}
