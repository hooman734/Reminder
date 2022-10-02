using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RWAPP.CoreBusiness;

public class Event
{
    public Guid EventId { get; init; } = Guid.NewGuid();
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(100, ErrorMessage = "Description lenght is bounded to 100 characters long!")]
    public string Description { get; set; } = string.Empty;
    
    [RegularExpression("^https?:\\/\\/(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = "The input is not a valid URL!")]
    public string Link { get; set; } = string.Empty;
    
    [Required]
    [DataType(DataType.Date, ErrorMessage = "Invalid date!")]
    public DateTime DueDate { get; set; } = DateTime.Today;
    public DateTime CreatedAt { get; } = DateTime.Now;
    
}