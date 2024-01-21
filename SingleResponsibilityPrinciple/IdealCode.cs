using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.IdealCode;

class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Aslı", Surname = "Sütçüoğlu" },
            new(){ Name = "Kubilay", Surname = "Peynircioğlu" },
            new(){ Name = "Tahsin", Surname = "Sütçüoğlu" }
        };
    }
}