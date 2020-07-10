using Raspberry.IO.GeneralPurpose;
using System;
using System.Threading;

namespace dotnet_raspberrypi_mono
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputPinConfiguration pin12 = ConnectorPin.P1Pin12.Output();
            pin12.Enabled = false;

            using (GpioConnection connection = new GpioConnection(pin12))
            {
                while (!Console.KeyAvailable)
                {
                    connection.Toggle(pin12);
                    Thread.Sleep(250);
                }
            }
        }
    }
}