
class Paypal : Payment
{
    public string Email { get; set; }

    public Paypal(int id, string email)
    {
        this.Id = id;
        this.Email = email;
    }
}