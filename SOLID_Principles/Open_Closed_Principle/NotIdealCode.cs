using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_NotIdealCode;

class ParaGonderici
{
    public void Gonder(int tutar)
    {
        //Garanti garanti = new();
        //garanti.HesapNo = "...";
        //garanti.ParaGonder(tutar);

        //Garanti'den Halkbank'a geçersen sadece referansları değiştirmekte kalmayıp, Halkban'a göre de olayı özelleştirmemiz gerekli.
        HalkBank halkbank = new();
        halkbank.GonderilecekHesapNo("1243213");
        halkbank.Gonder(tutar);
    }
}

//Benzer davranışları sergileyen iki sınıf arasında herhangi bir ortak çalışma-standart yok.
class Garanti //Garanti ParaGonder fonksiyonuyla gonderme işlemini yaparken bir yandan da hesap numarasını property'den almakta.
{
    public string HesapNo { get; set; }
    public void ParaGonder(int tutar)
    {
        //..
    }
}

class HalkBank //Halkbank ise hesap numarasını metottan karşılayıp, Gonder metodu ile de para gönderme işlemini sağlıyor.
{
    string hesapNo;
    public void GonderilecekHesapNo(string hesapNo)
    {

    }
    public void Gonder(int tutar)
    {

    }
}
