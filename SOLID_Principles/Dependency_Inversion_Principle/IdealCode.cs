using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_IdealCode;

class MailService
{
    public void SendMail(IMailServer mailServer, string to, string body) //Gmail'e bağımlılık var..
    {
        mailServer.Send(to, body);
    }
}

interface IMailServer //bağımlılık tersine döndü. 
{
    void Send(string to, string body);
}

class Gmail : IMailServer
{
    public void Send(string to, string mail)
    {
        //...
    }
}

class Yandex : IMailServer
{
    public void Send(string to, string mail)
    {
        //...
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string mail)
    {
        //...
    }
}