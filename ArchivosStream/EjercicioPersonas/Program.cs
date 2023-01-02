using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersonas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que realice la siguiente funcionalidad:

            //Se pedirá por consola el nombre de una persona, su edad y su localidad,
            //se guardara en un archivo con el siguiente formato, nombre | edad | localidad;
            //uno detrás del otro "|" separa datos ";" separa registros. Cuando se inserte,
            //se pedirá si quiere introducir más personas, "S o N", se podrán introducir personas
            //hasta que se pulse en "N".cuando se pulse en "N", se listaran todas las personas
            //que están introducidas en el archivo.
            //una vez se salga del programa, si lo volvemos a ejecutar e introducimos
            //mas personas, una vez pulsado de nuevo "N", tendrán que salir todas las
            //personas, las introducidas en veces anteriores y las nuevas.

            string filename = "personas.txt";
            FileStream fs;

            if (!File.Exists(filename))
            {
                fs = new FileStream(filename, FileMode.Create);
                fs.Close();
            }


            // true indica que se debe agregar al final del archivo
            StreamWriter writer = new StreamWriter(filename, true);


            Console.WriteLine("Dame Nombre de persona:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Dame Edad de persona:");
            string edad = Console.ReadLine();

            Console.WriteLine("Dame Localidad de persona:");
            string localidad = Console.ReadLine();



            writer.WriteLine(nombre + "|" + edad + "|" + localidad + ";");


            Console.WriteLine("Introducir mas personas Si (S), No (N)");

            char resp = Console.ReadLine()[0];

            while (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Dame Nombre de persona:");
                nombre = Console.ReadLine();

                Console.WriteLine("Dame Edad de persona:");
                edad = Console.ReadLine();

                Console.WriteLine("Dame Localidad de persona:");
                localidad = Console.ReadLine();

                writer.WriteLine(nombre + "|" + edad + "|" + localidad + ";");

                Console.WriteLine("Introducir mas personas Si (S), No (N)");

                resp = Console.ReadLine()[0];

            }

            writer.Close();

            StreamReader reader = new StreamReader(filename);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                string[] data = linea.Split('|');
                Console.WriteLine("Nombre: " + data[0] + "  Edad: " + data[1] + " Localidad: " + data[2]);
            }

            reader.Close();
            Console.ReadLine();



        }
    }
}
