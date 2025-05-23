using System.ComponentModel.DataAnnotations;

public class RegistrationModel
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    public bool IsAttending { get; set; }
}