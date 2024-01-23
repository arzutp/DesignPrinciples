using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.NotIdealCode;

class ParaGonderici
{
    public void Gonder(int tutar)
    {
        //Garanti garanti = new();
        //garanti.HesapNo = "...";
        //garanti.ParaGonder(tutar);
        Halkbank halkbank = new();
        halkbank.GonderilecekHesapNo("123");
        halkbank.Gonder(tutar);
    } 
}

class Garanti
{
    public string HesapNo { get; set; }
    public void ParaGonder(int tutar)
    {
        //
    }
}

public class Halkbank
{
    string _hesapNo;
    public void GonderilecekHesapNo(string hesapNo)
    {
        //...
    }
    public void Gonder(int tutar)
    {
        //...
    }
}