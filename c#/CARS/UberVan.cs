using System;

class UberVan : Car
{

  
    public string TypeCarAccepted { get; set; }
    public string SeatsMaterial { get; set; }

  
    public UberVan( string licenceC, Account driverC, string TypeCarAcceptedC, string SeatsMaterialC)
    {
        this.TypeCarAccepted = TypeCarAcceptedC;
        this.SeatsMaterial = SeatsMaterialC;
        this.Licence= licenceC;
        this.Driver = driverC;                        
    }
}