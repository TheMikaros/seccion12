using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream("miFile.txt", FileMode.Create);

            string cadena = "Esto es una cadena de ejemplo";

            Console.WriteLine("Prin cadena");


            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Close();


            fs = new FileStream("miFile.txt", FileMode.Append);
            cadena = "n Esto es una cadena agregada";

            Console.WriteLine("Print cadena agregada");

            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            fs.Close();

            byte[] infoArchivo = new byte[100];

            fs = new FileStream("miFile.txt", FileMode.Open);
            fs.Read(infoArchivo, 0, (int)fs.Length);

            Console.WriteLine(Encoding.ASCII.GetString(infoArchivo));
            Console.ReadKey();

            fs.Close();




        }
    }
}
