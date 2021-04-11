using System;
public class Car
{
    public int Id { get; set; }
    public string Licence { get; set; }
    public Account Driver { get; set; }
    public int Passenger { get; set; }

    // public Car(string licenceC, Account driverC)
    // {
    //     Licence = licenceC;
    //     Driver = driverC;
    // }

  
    public string PrintDataCaR()
    {
        return "La Licencia es: " + Licence + " El conductor es: " + Driver.Name;

    }

    public void Imprimir()
    {
        System.Console.WriteLine(PrintDataCaR());
    }

}



    