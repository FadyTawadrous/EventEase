using System.ComponentModel.DataAnnotations;

public class EventModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string Description { get; set; }

    public int TotalAttendees { get; set; } = 0;

    public int TrackedAttendees { get; set; } = 0;
}
