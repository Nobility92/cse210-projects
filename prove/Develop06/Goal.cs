using System;
using System.Collections.Generic;
using System.IO;

/*public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
       
    }

    public string GetShortName() => _shortName;
    public int GetPoints() => _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailString();
    public abstract string GetStringRepresentaion();
}*/

abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}
