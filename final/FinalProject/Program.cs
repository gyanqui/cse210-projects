using System;

public class Running : Exercise
{
    private float _distance;

    public Running(string date, float minutes, float distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed()
    {
        float speed = (_distance / _minutes) * 60;
        return Math.Round(speed, 1);
    }

    public override float CalculatePace()
    {
        float pace = _minutes / _distance;
        return Math.Round(pace, 1);
    }
}
