using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_NotIdealCode;

interface IPrinter
{
    void Print();
    void Scan();
    void Fax();
    void PrintDuplex();
}

class HPPrinter : IPrinter
{
    public void Print() { }
    public void Scan() { }
    public void Fax() { }
    public void PrintDuplex() { }
}
class SamsungPrinter : IPrinter
{
    public void Print() { }
    public void Fax() { }

     public void Scan()
    {
        throw new NotSupportedException();
    }

    public void PrintDuplex()
    {
        throw new NotSupportedException();
    }
}

class LexmarkPrinter
{
    public void Print() { }
    public void Fax() { }

    public void Scan() { }

    public void PrintDuplex()
    {
        throw new NotSupportedException();
    }
}