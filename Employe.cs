using System;

public class Employee
{
    public string Ssn { get; set; }
    public string Name { get; set; }

    public Employee(string ssn, string name )
	{
        Ssn = ssn;
        Name = name;
	}

    public override string ToString()
    {
        return $"Ssn: {Ssn}, Name: {Name}!";
    }
}
