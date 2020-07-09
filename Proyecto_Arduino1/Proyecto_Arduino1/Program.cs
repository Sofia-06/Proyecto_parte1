using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Proyecto_Arduino1
{
    public class Program
    {
        static char[,] datos = new Char[3, 3];
        static SerialPort Arduino = new SerialPort("COMS", 9600);

        public static void Main(string[] args)
        {
            
            Arduino.Parity = Parity.None;
            Arduino.StopBits = StopBits.One;
            Arduino.DataBits = 8;
            Arduino.Handshake = Handshake.None;
            Arduino.RtsEnable = true;
          
            if (Arduino.IsOpen)
            {
                Console.WriteLine("Com abierto");
                byte[] data = Encoding.ASCII.GetBytes("z");
                Arduino.Write(data, 0, data.Length);

                Arduino.Write("i");
            }
            else
            {
                Console.WriteLine("Com cerrado");
            }


            if (Arduino.IsOpen)
            {
                Console.WriteLine("Com abierto");
                byte[] data = Encoding.ASCII.GetBytes("p");
                Arduino.Write(data, 0, data.Length);

                Arduino.Write("l");
            }
            else
            {
                Console.WriteLine("Com cerrado");
            }

            if (Arduino.IsOpen)
            {
                Console.WriteLine("Com abierto");
                byte[] data = Encoding.ASCII.GetBytes("k");
                Arduino.Write(data, 0, data.Length);

                Arduino.Write("f");
            }
            else
            {
                Console.WriteLine("Com cerrado");
            }
        }
    }
}
