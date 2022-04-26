//1 uzdevums
public class Phone
{
    public string Size { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public void makeACall()
    {
        Console.WriteLine("Telephone is ringing");
    }

    public void sendSMS()
    {
        Console.WriteLine("SMS is sent");
    }
}