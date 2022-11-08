using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substituition_Principle_IdealCode;

abstract class Cloud
{
    public abstract void MachineLearning(); //base class'ımızdan evrensel olmayan ember'ı çıkardır. Translate artık dışarıda.
}

interface ITranslatable //bizim bütün Cloud sınıf'larda olmayacak, sadece belirlilerinde olacak özelliklerimi ayrı interfate'lere aldık.
{
    void Translate();
}
class AWS : Cloud, ITranslatable
{
    public void Translate() => Console.WriteLine("AWS Translate");
    public override void MachineLearning() => Console.WriteLine("AWS Machine Learning");
}

class Azure : Cloud //Azure cloud'unda Translate diye bir hizmet olmadığından dolayı sadece evrensel olan MachineLearning hizmeti mevcut.
{
    public override void MachineLearning() => Console.WriteLine("Azure Machine Learning");
}

class Google : Cloud, ITranslatable
{
    public void Translate() => Console.WriteLine("Google Translate");
    public override void MachineLearning() => Console.WriteLine("Google Machine Learning");
}

