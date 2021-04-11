using System;

class UberPool : Car
{
    public string Brand { get; set; }
    public string Model { get; set; }

  
    public UberPool( string licenceC, Account driverC, string brandC, string modelC)
    {
        this.Brand = brandC;
        this.Model = modelC;
        this.Licence= licenceC;
        this.Driver = driverC;               
    }
}