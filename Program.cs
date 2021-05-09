using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Cálculo de Área:");

            Circulo miCirculo;      //Variable/objeto
            miCirculo = new Circulo();      //Instanciar una clase, creación de ejemplar de Clase

            Console.WriteLine(miCirculo.Area(5));

            Circulo miCirculo2 = new Circulo();
            Console.WriteLine("Introducir un valor entero de radio: ");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine(miCirculo2.Area(radio));
        }
    }

    class Circulo
    {
        const double PI = 3.1416;     //Las variables son propiedades de la Clase
        //Campos de clase cuando están definidas dentro de una clase

        public double Area(int radio){     //Método de Clase. Qué hace el objeto Circulo? (Comportamientos)
            return PI * radio * radio;
        }
    }
}
