using System.Reflection;

namespace Listetrening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>();
            List<Employee> employees = new List<Employee>();

            companies.Add(new Company("Company 1"));
			companies.Add(new Company("Company 2"));
			companies.Add(new Company("Company 3"));

			Employee employee1 = new Employee("11111", "Per");
			Employee employee2 = new Employee("11112", "Kari");
			Employee employee3 = new Employee("11113", "Ola");
			Employee employee4 = new Employee("11114", "Lara");
			Employee employee5 = new Employee("11115", "Jonas");
			Employee employee6 = new Employee("11116", "Martine");



			companies[0].Employees.Add(employee1);
			companies[0].Employees.Add(employee2);
			companies[2].Employees.Add(employee3);
			companies[2].Employees.Add(employee4);
			companies[2].Employees.Add(employee5);
			companies[2].Employees.Add(employee6);

			/*
			foreach (Company company in companies)
			{
				Console.WriteLine($"Company name: {company.Name}");

				foreach (Employee employee in company.Employees)
				{
					Console.WriteLine(employee);
				}
			}
			*/
			Console.WriteLine("Skriv in SSN du vil søke etter: ");
			string searchSsn = Console.ReadLine() ?? "";

			foreach (Company company in companies)
			{
				foreach (Employee employee in company.Employees)
				{
					if (employee.Ssn == searchSsn )
					{
						Console.WriteLine($"SSN: {employee.Ssn}");
						Console.WriteLine($"Name: {employee.Name}");
						Console.WriteLine($"Company: {company.Name}");
					}
				}
			}
		}
    }
}
