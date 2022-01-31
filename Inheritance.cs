using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.SwitchOn();
            myTV.WatchTV();
        }
    }
    class ElectricalDevice
    {
        //boolean to determine the state (on or off) of the Electrical Device
        public bool IsOn { get; set; }

        //string for the brand name of the Electrical Device
        public string Brand { get; set; }

        //constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        //switch on the Electrical Device
        public void SwitchOn()
        {
            IsOn = true;
        }
        //switch off the Electrical Device
        public void SwitchOff()
        {
            IsOn = false;
        }
    }
    class Radio : ElectricalDevice
    {


        //constructor for radio inherits from the base class using the base keyword
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            //body isn't necessary unless it's unique
        }


        //method to listen to the radio
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }

        }
    }
    class TV : ElectricalDevice
    {

        //constructor
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        //method to listen to the TV
        public void WatchTV()
        {
            //first check if the TV is on
            if (IsOn)
            {
                //listen to TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
