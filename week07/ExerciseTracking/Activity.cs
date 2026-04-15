using System;
using System.Collections.Generic;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
       _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
{
    return _minutes;
}

public abstract double GetDistance();
public abstract double GetSpeed();
public abstract double GetPace();

public string GetSummary()
    {
        return $"{_date} {_minutes} min - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}    