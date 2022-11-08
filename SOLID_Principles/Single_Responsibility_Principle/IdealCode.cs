using Single_Responsibility_Principle;
using System;

namespace Single_Responsibility_Principle_IdealCode;

class Database
{
    public void Connect()
    {
        //..
        Console.WriteLine("Veritabanı bağlantısı başarılı.");
    }
    public void Disconnect()
    {
        //..
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }

}

class PersonService
{
    public List<Person> GetPersons() //ilgili sınıfa taşıdık.
    {
        return new()
        {
            new() { Name = "Ali", Surname = "Taşıyanboğa"},
            new() { Name = "Hakan", Surname = "Turtle"},
            new() { Name = "Mahmut", Surname = "Ertunc"},
        };
    }
}