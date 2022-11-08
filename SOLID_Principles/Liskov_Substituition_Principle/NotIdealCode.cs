using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substituition_Principle_NotIdealCode;

//Amazon ve Google'ın translate işlemleri mevcutken, Azure böyle bir hizmet sunmamakta.
abstract class Cloud
{
    public abstract void Translate();
    public abstract void MachineLearning();
}

class AWS : Cloud
{
    public override void Translate() => Console.WriteLine("AWS Translate");
    public override void MachineLearning() => Console.WriteLine("AWS Machine Learning");
}

class Azure : Cloud
{
    public override void Translate() => throw new NotImplementedException(); //fakat yine de burayı zorunlu olarak implement ettik.
    public override void MachineLearning() => Console.WriteLine("Azure Machine Learning");
}

class Google : Cloud
{
    public override void Translate() => Console.WriteLine("Google Translate");
    public override void MachineLearning() => Console.WriteLine("Google Machine Learning");
}

//işte buna kötü tasarım diyoruz. Liskov uygulanmalı.