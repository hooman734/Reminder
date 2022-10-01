using System.ComponentModel.DataAnnotations;

namespace RWAPP.CoreBusiness;

public class Event
{
    public Guid EventId { get; init; } = Guid.NewGuid();
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(200, ErrorMessage = "Description lenght is bounded to 200 characters long!")]
    public string Description { get; set; } = string.Empty;
    
    [DataType(DataType.Url, ErrorMessage = "The input is invalid URL!")]
    public string Link { get; set; } = string.Empty;
    
    [Required]
    [DataType(DataType.Date, ErrorMessage = "Input must be in Date format")]
    public DateTime DueDate { get; set; } = DateTime.Today;
    public DateTime CreatedAt { get; } = DateTime.Now;
    
}