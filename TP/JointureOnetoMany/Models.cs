public class Department
{
	public int DepartmentId { get; set; }
	public string Name { get; set; }

	public virtual ICollection<Employee> Employees { get; set; }
}

public class Employee
{
	public int EmployeeId { get; set; }
	public string Name { get; set; }
	public int DepartmentId { get; set; }

	public virtual Department Department { get; set; }
}
