using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la marca del telefono:");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del telefono:");
            string modelo = Console.ReadLine();
            Telefono t1 = new Telefono(marca, modelo);

            Console.WriteLine("Ingrese el número de telefono: ");
            string telefono = Console.ReadLine();
            t1.NumeroTelefonico = telefono;

            Console.WriteLine("Ingrese el código de operador: ");
            int codigo = int.Parse(Console.ReadLine());
            t1.CodigoOperador = codigo;

            Console.WriteLine("Ingrese el contacto: ");
            string contacto = Console.ReadLine();

            Console.WriteLine("Marca: " + t1.Marca.ToUpper());
            Console.WriteLine("Modelo: " + t1.Modelo.ToUpper());
            Console.WriteLine("Número Telefónico " + t1.NumeroTelefonico);
            Console.WriteLine("Código Operador " + t1.CodigoOperador);
            Console.WriteLine(t1.llamar());
            Console.WriteLine(t1.llamar(contacto.ToUpper()));

            Console.ReadKey();
        }
    }
}
