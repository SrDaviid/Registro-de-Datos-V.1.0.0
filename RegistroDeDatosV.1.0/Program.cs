using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace RegistroDeDatosV._1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "filename.csv";

            using (StreamWriter sw = File.AppendText (filename))
            {
                sw.WriteLine("ID, Name, Last Name, Age");

                Console.WriteLine("Cual es tu cedula?");
                int cedula = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cual es tu nombre?");
                string nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cual es tu apellido?");
                string apellido = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Cual es tu edad");
                int edad = Convert.ToInt32(Console.ReadLine());

                sw.WriteLine(+ cedula +" , "+ nombre +" , "+ apellido +" , "+ edad);

            }     
                  
        }
       
    }
}
