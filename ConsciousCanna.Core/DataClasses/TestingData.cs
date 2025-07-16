using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsciousCanna.Core.DataClasses;

public enum TestingUnit
{
    None,
    Percent,
    Mg
}

public class TestingData
{
    public required TestingUnit Unit { get; set; }

    public double THC { get; set; }

    public double THCA { get; set; }

    public double THCP { get; set; }

    public double THCV { get; set; }

    public double THCVA { get; set; }

    public double D8THC { get; set; }

    public double CBD { get; set; }

    public double CBDA { get; set; }

    public double CBN { get; set; }

    public double CBG { get; set; }

    public double CBGA { get; set; }

    public double CBC { get; set; }

    // Terpenes 

    public double Camphene { get; set; }

    public double bCaryophyllene { get; set; }

    public double aBisabolol { get; set; }

    public double CaryophylleneOxide { get; set; }

    public double Farnesene { get; set; }

    public double Fenchol { get; set; }

    public double Garaniol { get; set; }

    public double Guaiol { get; set; }

    public double aHumulene { get; set; }

    public double Linalool { get; set; }

    public double Limonene { get; set; }

    public double Mrycene { get; set; }

    public double Nerolidol { get; set; }

    public double Ocimene { get; set; }

    public double aPhellandrene { get; set; }

    public double aPinene { get; set; }

    public double bPinene { get; set; }

    public double aTerpinene { get; set; }

    public double Terpinolene { get; set; }

    public double Terpineol { get; set; }

    public double Valencene { get; set; }
}
