namespace Lab6.Models;

public class User
{
    public string Name { set; get; }
    public int Age { set; get; }

    public User()
    {
        Name = "None";
        Age = 1;
    }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}