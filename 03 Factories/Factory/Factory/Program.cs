namespace Factory;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class PersonFactory
{
    private int _index = 0;
    
    public Person CreatePerson(string name)
    {
        return new Person(_index++, name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}