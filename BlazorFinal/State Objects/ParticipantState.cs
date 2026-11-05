namespace BlazorFinal.StateObjects;
using System.ComponentModel.DataAnnotations;

class ParticipantState
{
    [Required(ErrorMessage = "Enter first name!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "2 charcter min, 30max.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Enter second name!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "2 charcter min, 30max.")]
    public string? SecondName { get; set; }

    [Required(ErrorMessage = "Enter your email!")]
    [EmailAddress]
    public string? Email { get; set; }

    public bool Attended { get; set; } = false;
    
    public DateTime ArrivalTime { get; set; }
}