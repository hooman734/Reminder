using System.ComponentModel.DataAnnotations;

namespace RWAPP.CoreBusiness;

public class Event
{
    public Guid EventId { get; init; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(200)]
    public string Description { get; set; } = string.Empty;
    
    [DataType(DataType.Url)]
    public string Link { get; set; } = string.Empty;
    
    [Required]
    [DataType(DataType.Date)]
    public string DueDate { get; set; } = string.Empty;
    
    public string CreatedAt { get; init; } = DateTime.Now.ToLongDateString();
}