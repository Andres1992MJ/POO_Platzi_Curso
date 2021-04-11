using System;

class UberBlack : Car
{

  
    public string TypeCarAccepted { get; set; }
    public string SeatsMaterial { get; set; }

  
    public UberBlack( string licenceC, Account driverC, string TypeCarAcceptedC, string SeatsMaterialC)
    {
        this.TypeCarAccepted = TypeCarAcceptedC;
        this.SeatsMaterial = SeatsMaterialC;
        this.Licence= licenceC;
        this.Driver = driverC;                        
    }
}