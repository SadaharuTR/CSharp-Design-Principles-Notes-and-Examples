using Single_Responsibility_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle_NotIdealCode;

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

    public List<Person> GetPersons() //veritabanı ile ilgili değil.
    {
        return new()
        {
            new() { Name = "Ali", Surname = "Taşıyanboğa"},
            new() { Name = "Hakan", Surname = "Turtle"},
            new() { Name = "Mahmut", Surname = "Ertunc"},
        };
    }
}
