using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.NotIdealCode;

interface IPrinter
{
    void Print();
    void Scan();
    void Fax();
    void PrintDuplex();

}

class HPPrinter : IPrinter
{
    public void Fax()
    {
        //fax 
    }

    public void Print()
    {
        //print
    }

    public void PrintDuplex()
    {
        //print duplex
    }

    public void Scan()
    {
        //scan
    }
}

class SamsungPrinter : IPrinter
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void PrintDuplex()
        => throw new NotImplementedException();


    public void Scan()
        => throw new NotImplementedException();
}

class LexmarkPrinter : IPrinter
{
    public void Fax()
    {
        //... Fax işlemleri ...
    }

    public void Print()
    {
        //... Print işlemleri ...
    }

    public void PrintDuplex()
        => throw new NotSupportedException();

    public void Scan()
    {
        //... Scan işlemleri ...
    }
}