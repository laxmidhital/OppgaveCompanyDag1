using System;

public class Company
{
	public string Name { get; set; }
	public List<Employee> Employees { get; set; }

	public Company(string name)
	{
		Name = name;
		Employees = new List<Employee>();
	}
	public override string ToString()
	{
		return $"Name: {Name}, Employees: {Employees}";
	}
}
