namespace ConsoleApp1
{
    public class Taiwan
    {
        static void Main()
        {
            Gossiping gossiping = new Gossiping();
            Passenger passenger = new Passenger();
            FourPercent fourPercent = new FourPercent();
            Green green = new Green();

            string news = "開放美豬進口了";
            gossiping.Notify(passenger.ReceiveNews, news);
            gossiping.Notify(fourPercent.Argue, news);
            gossiping.Notify(green.Support, news);
        }
    }
}