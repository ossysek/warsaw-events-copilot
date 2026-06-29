namespace WarsawEvents.Domain.DTOs;

/// <summary>
/// Data transfer object for Event
/// </summary>
public class EventDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime EventDate { get; set; }
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }
    public string Organizer { get; set; } = string.Empty;
    public string? AgendaUrl { get; set; }
    public int RegisteredCount { get; set; }
    public int AvailableSpots { get; set; }
    public bool IsFull { get; set; }
    public bool IsInPast { get; set; }
    public bool CanRegister { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

/// <summary>
/// DTO for creating/updating events
/// </summary>
public class CreateEventDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime EventDate { get; set; }
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }
    public string Organizer { get; set; } = string.Empty;
    public string? AgendaUrl { get; set; }
}

/// <summary>
/// DTO for updating events
/// </summary>
public class UpdateEventDto
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public DateTime? EventDate { get; set; }
    public string? ImageUrl { get; set; }
    public int? Capacity { get; set; }
    public string? Organizer { get; set; }
    public string? AgendaUrl { get; set; }
    public bool? IsActive { get; set; }
}
