// Jack Herdejurgen 113436899
// Lecture Code Sept 6, 2022
// Class, complex data types: string, datatime
// Collections; array, list, dictionary

Person p1 = new Person(); //101
Person p2 = new Person("Jack", 23, 180); //102

// String
string str1 = new string("");
string str2 = "String";

// DateTime
DateTime dt1 = new DateTime();
DateTime dt2 = new DateTime(2000,2,20,14,20,30);
DateTime dt3 = DateTime.Now;

// Array

// List

// Dictionary

// Static

Console.ReadLine();
public class Person
{
    // Constructor Function
    // function_name(){}
    public Person()
    {
        
    }
    public Person(string name, int age, double weight)
    {
        this.name = name;
        this.age = age;
        this.weight = weight;
    }
    public string name;
    public int age;
    public double weight;

    public static string Restaurant { get; set; } = "Chilis";
}