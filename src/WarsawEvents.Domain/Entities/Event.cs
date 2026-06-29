namespace WarsawEvents.Domain.Entities;

/// <summary>
/// Represents a Warsaw technology event
/// </summary>
public class Event
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime EventDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? ImageUrl { get; set; }
    public int Capacity { get; set; }
    public string Organizer { get; set; } = string.Empty;
    public string? AgendaUrl { get; set; }
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets the number of registrations for this event
    /// </summary>
    public int RegisteredCount { get; set; }

    /// <summary>
    /// Gets available spots for the event
    /// </summary>
    public int AvailableSpots => Capacity - RegisteredCount;

    /// <summary>
    /// Gets whether the event is full
    /// </summary>
    public bool IsFull => AvailableSpots <= 0;

    /// <summary>
    /// Gets whether the event is in the past
    /// </summary>
    public bool IsInPast => EventDate < DateTime.UtcNow;

    /// <summary>
    /// Gets whether registration is still available
    /// </summary>
    public bool CanRegister => IsActive && !IsFull && !IsInPast;
}
