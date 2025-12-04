namespace Task4;

public class Student(string name, DateOnly dob, string gender)
{
    public string Name { get; set; } = name;
    public DateOnly Dob { get; set; } = dob;
    public string Gender { get; set; } = gender;
}