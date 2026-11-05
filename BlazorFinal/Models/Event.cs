using System.ComponentModel.DataAnnotations;

class Event
{

    private List<Participant> ParticipantList = new List<Participant>();
    private static int idCounter = 0;

    [Required(ErrorMessage = "Event name cannot be empty.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be at least 3 characters long but no longer than 50.")]
    public string? Name { get; set; }


    [Required(ErrorMessage = "Event location cannot be empty.")]
    public string? Location { get; set; }


    [Required(ErrorMessage = "Set Event Date!")]
    [ValidateDate]
    public DateTime Date { get; set; } = DateTime.UtcNow;


    [Required]
    [Range(1, 10000, ErrorMessage = "Participant amount min:1 max:10000")]
    public int ParticipantMax { get; set; } = 40;


    public int EventId { get; private set; }

    public int AttntedTotal{get; private set;} = 0;

    public void SetEventId()
    {
        EventId = idCounter;
        idCounter++;
    }

    public void AddParcitipant(Participant participant) => ParticipantList.Add(participant);
    
    public int GetParcitipantsCount() => ParticipantList.Count;
    
    public Participant[] GetParcitipantArray() => ParticipantList.ToArray();
   
    public void RemoveParcitipant(int i) => ParticipantList.RemoveAt(i);
  
    public void EditParcitipant(int i, Participant participant) => ParticipantList[i] = participant;
    
    public Participant GetParcitipant(int i)
    {
        return ParticipantList[i];
    } 

    public void HandleArrivalTime(int i)
    {
        ParticipantList[i].Attended = true;
    }

    public void SetAttntedTotal(int i) => AttntedTotal = i;
   
}