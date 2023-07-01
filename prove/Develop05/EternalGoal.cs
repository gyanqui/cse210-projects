using System;

public class EternalGoal : Goal
{
    private int _stepCounter;

    public EternalGoal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _stepCounter = 0;
    }
    public EternalGoal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _stepCounter = 0;
    }
    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal:" + _name + "," + _description + "," + _goalPoints.ToString();
        return line;
    }

    public override void RecordEvent()
    {
        _stepCounter ++;
    }
    public override int CalculateAGP()
    {
        int points = _goalPoints;
        return points;
    }
}