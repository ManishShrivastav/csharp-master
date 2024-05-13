using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HoteRoomModel room = new HoteRoomModel();

            room.TurnOnAir().SetTemperature(72).OpenShades();

            room.TurnOffAir().CloseShades();

            "Hello World".PrintToConsole();
            Console.ReadLine();
        }
    }

    public class HoteRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }

    public static class ExtensionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HoteRoomModel TurnOnAir(this HoteRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HoteRoomModel TurnOffAir(this HoteRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HoteRoomModel SetTemperature(this HoteRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HoteRoomModel OpenShades(this HoteRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }
        public static HoteRoomModel CloseShades(this HoteRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
