using System;

namespace UnitTestDemo
{
    public class SerialPortParser
    {
        public static int ParsePort(string port)
        {
            if (!port.StartsWith("COM"))
            {
                throw new FormatException("Naam poort niet in juiste formaat");
            }
            else
            {
                const int lastIndexOfPrefix = 3;
                string portNr = port.Substring(lastIndexOfPrefix);
                return int.Parse(portNr);
            }
        }
    }
}
