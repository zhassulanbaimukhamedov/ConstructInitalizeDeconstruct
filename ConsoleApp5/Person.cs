public class Person
{
    public string name;
    public int age;
    public Company company = new Company();
    
    public string msg = "msg";
    public Person()
    {
         company = new Company();
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;

    }
     
    public void Print()
    {
        Console.WriteLine($"Name: {name}, age: {age}, company: {company.title}, msg: {msg}");
    }
    
}


