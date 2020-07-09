using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace Proyecto_Arduino1
{
    class Program
    {
        
        static SerialPort Arduino = new SerialPort("COM27", 9600);

        static void Main(string[] args)
        {
            
            Arduino = Open();

            Arduino.Parity = Parity.None;
            Arduino.StopBits = StopBits.One;
            Arduino.DataBits = 8;
            Arduino.Handshake = Handshake.None;
            Arduino.RtsEnable = true;

            // Mi grupo: Keyli Solis, Fatima Ventura, y mi persona: (Sofia Sabán)

            if (Arduino.IsOpen)
            {
                Console.WriteLine("Com abierto");
                byte[] data = Encoding.ASCII.GetBytes("z");
                Arduino.Write(data, 0, data.Length);

                Console.WriteLine("Com abierto");
                byte[] data1 = Encoding.ASCII.GetBytes("p");
                Arduino.Write(data1, 0, data1.Length);

                Console.WriteLine("Com abierto");
                byte[] data2 = Encoding.ASCII.GetBytes("k");
                Arduino.Write(data2, 0, data2.Length);
                Arduino.Write("l");
            }
            else
            {
                Console.WriteLine("Com cerrado");
            }

            Console.ReadKey();
            Arduino.Close();
        }
    }
}
