using Lab;
using Lab.Batteries;
using Lab.Output;
using Lab.Speakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            SimcorpMobile Phone= new SimcorpMobile();
            Console.WriteLine(Phone);

            IPlayback playbackComponent = GetPlaybackComponent();
            Console.WriteLine($" {playbackComponent} selected");
            Console.WriteLine(" Set playback to Mobile ...");
            Console.WriteLine(" Play sound in Mobile:");
            playbackComponent.Play(new object());

            ICharger chargingDevice = GetChargingDevice();
            chargingDevice.Charge(Phone.Battery);
            Console.ReadKey();
        }

        private static ICharger GetChargingDevice()
        {
            Console.WriteLine("Select playback component (specify index):");
            ICharger[] allChargingDevices = new ICharger[]
{
                new OriginalCharger(new ConsoleOutput()),
                new PowerBank(new ConsoleOutput()),
                new UnknownCharger(new ConsoleOutput())
};
            for (int i = 0; i < allChargingDevices.Length; i++)
            {
                Console.WriteLine($" {i + 1} - {allChargingDevices[i]}");
            }
            int index = ReadIndex(allChargingDevices.Length);
            return allChargingDevices[index - 1];
        }
    

        static IPlayback GetPlaybackComponent()
        {
            Console.WriteLine("Select playback component (specify index):");
            IPlayback[] allPlaybackDevices = new IPlayback[]
{
                new iPhoneHeadset(new ConsoleOutput()),
                new SamsungHeadset(new ConsoleOutput()),
                new UnknownHeadset(new ConsoleOutput()),
                new PhoneSpeaker(new ConsoleOutput())
};
            for (int i=0; i<allPlaybackDevices.Length;i++)
            {
                Console.WriteLine($" {i+1} - {allPlaybackDevices[i]}");
            }
            int index = ReadIndex(allPlaybackDevices.Length);
            return allPlaybackDevices[index-1];
        }

        static int ReadIndex(int number)
        {
            int index = 0;
            while (index == 0)
            {
                try
                {
                    var input = Console.ReadLine();
                    index = Int32.Parse(input);
                    if (index < 1 || index > number)
                    {
                        index = 0;
                        Console.WriteLine("Wrong input. Try to input digit from 1 to " + number);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input. Try to input digit from 1 to " + number);
                }
            }
            return index;
        }
    }
}
