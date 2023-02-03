public class Person
{
	public int PersonId { get; set; }
	public string Name { get; set; }
	public virtual Passport Passport { get; set; }

	// Foreign key
	public int PassportId { get; set; }
}

public class Passport
{
	public int PassportId { get; set; }
	public string PassportNumber { get; set; }
	public virtual Person Person { get; set; }

	// Foreign key
	public int PersonId { get; set; }
}
