using System;

namespace Examples.FrameworkClassLibrary.Event
{
    public class EventDemo
    {
        public static void Demo()
        {
            var weather = new WheatherCast();
            weather.WeatherChanges("sunny");
            weather.WeatherChanges("rainning");
            weather.MyEvent += TestInterfaceEvent;
            weather.FireAway(new { Name = "CustomizedEventSender" }, new EventArgs());
        }

        public static void TestInterfaceEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Test the event which inherited from the interface");
        }
    }

    class WheatherCast : ICast
    {
        public delegate void RainningHandler();
        public event RainningHandler Rain;
        public event EventHandler MyEvent;

        public WheatherCast()
        {
            this.Rain += GetClothesBack;
        }

        private void GetClothesBack()
        {
            Console.WriteLine("It's rainning outside,please get the stuff inside");
        }

        public void WeatherChanges(string name)
        {
            if (name == "rainning")
            {
                Rain.Invoke();
            }
            else
            {
                Console.WriteLine("Having fun outside~");

            }
        }

        public void FireAway(object sender, EventArgs e)
        {
            this.MyEvent.Invoke(sender, e);
        }
    }

    interface ICast
    {
        event EventHandler MyEvent; //using default EventHandler to define a event
        void FireAway(object sender, EventArgs e);
    }
}
