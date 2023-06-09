using System.ComponentModel.DataAnnotations;

namespace WebUI.Models;

public class Company
{
    public Company()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }

    [Required]
    [Display(Name = "Company Id")]
    public Guid Id { get; set; }

    [Required]
    [Display(Name = "Company Name")]
    public string Name { get; set; }

    [Required]
    public int BusinessRegistrationNumber { get; set; }

    [Required]
    public bool IsActive { get; set; }

    [Required]
    public bool IsDeleted { get; set; }

    [Required]
    public DateTimeOffset CreatedAt { get; set; }

    [Required]
    public string CreatedBy { get; set; }
}