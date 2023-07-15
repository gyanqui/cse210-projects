using System;

public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string GenerateDetailedReception()
    {
        string detailed = GenerateStandard() + "\n";
        detailed += "RSVP: " + _email;
        return detailed;
    }
    public string GenerateShortReception()
    {
        string shortReception = "";
        string eventType = ReturnEventType();
        shortReception += "Event Type: " + eventType + "\n";
        shortReception += GenerateShort();
        return shortReception;
    }
}