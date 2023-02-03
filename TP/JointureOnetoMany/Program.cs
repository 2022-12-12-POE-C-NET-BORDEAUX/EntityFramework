using Microsoft.EntityFrameworkCore;

class Program
{
	static void Main(string[] args)
	{
		using (var context = new MyContext())
		{
			// Créer un nouveau département
			var department = new Department()
			{
				Name = "Informatique"
			};
			context.Departments.Add(department);
			context.SaveChanges();

			// Ajouter un nouvel employé à ce département
			var employee = new Employee()
			{
				Name = "John Doe",
				Department = department
			};
			context.Employees.Add(employee);
			context.SaveChanges();

			// Récupérer tous les employés d'un département
			var employees = context.Employees
				.Where(e => e.Department.DepartmentId == department.DepartmentId)
				.ToList();

			// afficher le nom de tous les employés
			foreach (var e in employees)
			{
				Console.WriteLine(e.Name);
			}

			// Mettre à jour le nom d'un employé
			var updateEmployee = context.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
			updateEmployee.Name = "Jane Doe";
			context.SaveChanges();

			// Supprimer un employé
			var deleteEmployee = context.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
			context.Employees.Remove(deleteEmployee);
			context.SaveChanges();
		}
	}
}
