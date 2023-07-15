using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "The weather will be " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string GenerateDetailedOutdoorGathering()
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherStatement();
        
        detailed += GenerateStandard() + "\n";
        detailed += "Statement of the Weather: " + weatherStatement;
        return detailed;
    }
    public string GenerateShortOutdoorGathering()
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Event Type: " + eventType + "\n";
        shortOG += GenerateShort();
        return shortOG;
    }
}