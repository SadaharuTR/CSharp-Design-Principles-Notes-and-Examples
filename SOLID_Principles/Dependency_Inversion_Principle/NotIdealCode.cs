using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_NotIdealCode;

class MailService
{
    public void SendMail(Gmail gmail) //Gmail'e bağımlılık v ar..
    {
        gmail.Send("...");
    }
}

class Gmail
{
    public void Send(string mail)
    {
        //...
    }
}

class Yandex
{
    public void SendMail(string mail, string to)
    {
        //...
    }
}
