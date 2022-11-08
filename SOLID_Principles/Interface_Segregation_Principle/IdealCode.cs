using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle_IdealCode;

interface IPrint
{
    void Print();
}
interface IScan
{
    void Scan();
}
interface IFax
{  
    void Fax();
}
interface IPrintDublex
{    
    void PrintDuplex();
}
class HPPrinter : IPrint, IScan, IFax, IPrintDublex
{
    public void Print() { }
    public void Scan() { }
    public void Fax() { }
    public void PrintDuplex() { }
}
class SamsungPrinter : IPrint, IFax
{
    public void Print() { }
    public void Fax() { }

}

class LexmarkPrinter : IPrint, IScan, IFax
{
    public void Print() { }
    public void Fax() { }
    public void Scan() { }

}
