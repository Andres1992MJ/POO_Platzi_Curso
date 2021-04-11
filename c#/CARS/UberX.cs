using System;

class UberX : Car
{
    public string Brand { get; set; }
    public string Model { get; set; }

  
    public UberX( string licenceC, Account driverC, string brandC, string modelC)
    {
        this.Brand = brandC;
        this.Model = modelC;
        this.Licence= licenceC;
        this.Driver = driverC;    
        
            
    }
}

