using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling.InDependecy;

class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("aaaa@fff.com", "lllll");
    }
}

interface IMailServer
{
    void Send(string to, string body);
}

class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        Console.WriteLine("Gmail");
    }
}

class HotMail : IMailServer
{
    public void Send(string to, string body)
    {
        Console.WriteLine("Hotmail");
    }
}

class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        Console.WriteLine("Yandex");
    }
}