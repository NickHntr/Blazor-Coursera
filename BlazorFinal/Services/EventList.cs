
using BlazorFinal.Pages;

class EventList
{
    private List<Event> EventsList = new List<Event>();
   
    private List<Event> EventsHystory = new List<Event>();


    public Event[] GetEventArray()
    {
        Console.WriteLine("GetEventArray");
        return EventsList.ToArray();
    }


    public void AddEvent(Event userEvent) => EventsList.Add(userEvent);
   

    public void DeleteEvent(int i)
    {
        var itemToRemove = EventsList.Single(r => r.EventId == i);
        EventsList.Remove(itemToRemove);
    }

    public Event GetEvent(int id) => EventsList.Single(r => r.EventId == id);
   

    public void EditEvent(Event userEvent, int id)
    {
        EventsList[EventsList.IndexOf(EventsList.Single(r => r.EventId == id))] = userEvent;
    }
    public void MoveEventToHistory(int id)
    {
        var itemToMove = EventsList.Single(r => r.EventId == id);
        EventsHystory.Add(itemToMove);
        DeleteEvent(id);
    }
    public Event[] GetEventHistoryArray() => EventsHystory.ToArray();
    
    public Event GetEventHistory(int id) => EventsHystory.Single(e => e.EventId == id);
}