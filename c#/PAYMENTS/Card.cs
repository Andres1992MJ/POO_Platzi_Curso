
class Card : Payment
{
    public int Number { get; set; } 
    public int Cvv { get; set; }
    public string Date { get; set; }

    public Card(int number, int cvv, string date, int id)
    {
        this.Id = id;
        this.Number = number;
        this.Cvv = cvv;
        this.Date = date;
    }
}