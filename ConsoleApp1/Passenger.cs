using System;

namespace ConsoleApp1
{
    public class Passenger
    {
        public void ReceiveNews(string news)
        {
            Console.WriteLine($"Passenger:我收到一則新聞內容是:{news}");
        }
    }
}