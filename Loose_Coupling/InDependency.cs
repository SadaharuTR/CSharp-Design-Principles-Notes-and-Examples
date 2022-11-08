using Loose_Coupling_InDependency;

namespace Loose_Coupling_InDependency;

class MailSender
{
    public void Send(IMailServer mailServer) //artık MailSender, kullanacağı server neyse onu IMailServer türünden bir parametre ile alıyor.
    {
        mailServer.Send("derdiniderman@spiderman.com", "Peter");
    }
}
interface IMailServer
{
    void Send(string to, string body); //IMailServerr içerisinde bir standart getiriyor. Ayrıca bu interface'i kullanan alt sınıflara bir düzen getiriyor.
}

class Gmail : IMailServer //mesela Gmail üzerinde bir değişiklik yapıldığında bu değişiklik MailSender'a yansımayacaktır.
{
    public void Send(string to, string body)
    {
        //bu sayede istediğimiz kadar Gmail sınıfında metotlarda, parametrelerde, constructor'larda çalışma gerçekleştirebiliriz.
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {

    }
}
class Yandex : IMailServer
{
    public void Send(string to, string body)
    {

    }
}