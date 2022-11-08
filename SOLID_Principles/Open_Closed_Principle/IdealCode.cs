using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_IdealCode;

class ParaGonderici
{
    public void Gonder(IBanka banka, int tutar, string hesapNo) //bu interface'e hangi nesne verildiyse onun para transferi fonksiyonunu çalıştır.
    {
        banka.ParaTransferi(tutar, hesapNo); //Loose Coupling'i burada uygulamış olduk.
    }
}

interface IBanka //sistemde kullanılacak tüm davranışların üst referansı gibi düşünülebilir.
{
    bool ParaTransferi(int tutar, string hesapNo);
}
class Garanti : IBanka
{
    public string HesapNo { get; set; }
    public int ParaGonder(int tutar)
    {
        return tutar * 20;
    }

    bool IBanka.ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            HesapNo = hesapNo;
            ParaGonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}

class HalkBank : IBanka
{
    string hesapNo;
    public void GonderilecekHesapNo(string hesapNo)
    {

    }
    public void Gonder(int tutar)
    {

    }

    bool IBanka.ParaTransferi(int tutar, string hesapNo)
    {
        try
        {
            GonderilecekHesapNo(hesapNo);
            Gonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}