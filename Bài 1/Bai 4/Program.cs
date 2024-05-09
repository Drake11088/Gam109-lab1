using System;
using System.Collections.Generic;

public class studen
{
    public string Name { get; set; }
    public int Age { get; set; }
    public studen(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
class Program
{
    static void Main()
    {
        List<studen> studenlist = new List<studen>();

        studenlist.Add(new studen("Alice", 20));
        studenlist.Add(new studen("Bob", 22));
        studenlist.Add(new studen("Charlie", 21));

        foreach (var student in studenlist)
        {
            student.DisplayInfo();
        }

    }
}