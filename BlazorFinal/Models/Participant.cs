using System.ComponentModel.DataAnnotations;

 class Participant
{
    [Required(ErrorMessage = "Enter first name!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "2 charcter min, 30max.")]
    public string? FirstName { get; set; }

    [Required(ErrorMessage = "Enter second name!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "2 charcter min, 30max.")]
    public string? SecondName { get; set; }

    [Required(ErrorMessage = "Enter Email!")]
    [EmailAddress]
    public string? Email { get; set; }

    public bool Attended { get; set;}
    
    public DateTime ArrivalTime { get; set;}
}