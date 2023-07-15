using System;

public class Running : Exercise
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculateSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double CalculatePace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}