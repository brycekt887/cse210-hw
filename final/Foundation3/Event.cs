public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        return _title + "\n" +
               _description + "\n" +
               _date + " at " + _time + "\n" +
               _address.GetFullAddress();
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public string ShortDescription()
    {
        return GetType().Name + " - " + _title + " on " + _date;
    }
}
