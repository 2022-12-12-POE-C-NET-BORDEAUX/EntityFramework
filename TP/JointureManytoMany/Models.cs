public class Student
{
	public int StudentId { get; set; }
	public string Name { get; set; }
	public virtual ICollection<StudentCourse> StudentCourses { get; set; }
}

public class Course
{
	public int CourseId { get; set; }
	public string Name { get; set; }
	public virtual ICollection<StudentCourse> StudentCourses { get; set; }
}

public class StudentCourse
{
	public int StudentId { get; set; }
	public Student Student { get; set; }
	public int CourseId { get; set; }
	public Course Course { get; set; }
}

