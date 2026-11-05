namespace BlazorFinal.StateObjects;
using System.ComponentModel.DataAnnotations;

class EventState
{
    private static int idCounter = 0;

    public EventState()
    {
        EventId = idCounter;
        idCounter++;
    }

    [Required(ErrorMessage = "Event name cannot be empty.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters long but no longer than 100.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Event location cannot be empty!")]
    public string Location { get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "Participant amount min:1 max:10000")]
    public int ParticipantMax { get; set; } = 40;



    [Required(ErrorMessage = "Set Event Date!")]
    [ValidateDate]
    public DateTime Date { get; set; } = DateTime.UtcNow;



    public int EventId { get; set; }

}