using System;

namespace ConsoleApp1
{
    public class Gossiping
    {
        public void Notify(Action<string> action, string news)
        {
            action(news);
        }
    }
}


