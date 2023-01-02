using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MemoryStream memStream = new MemoryStream();

            string miInfo = string.Empty;

            var capacidad = memStream.Capacity;
            var longitud = memStream.Length;
            var posicion = memStream.Position;

            byte[] buffarray = new byte[60];

            Console.WriteLine("Put Info: ");
            miInfo = Console.ReadLine();

            memStream.Write(ASCIIEncoding.ASCII.GetBytes(miInfo), 0, miInfo.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            memStream.Read(buffarray, 0, 5);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffarray));
            Console.ReadKey();

                   }
    }
}
