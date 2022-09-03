using System;
using System.Collections;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de estudiantes que desea evaluar: ");
            int numberStudent = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            ArrayList lista = new ArrayList();
            string nombre;
            int edad;
            double lab1;
            double lab2;
            double parcial;
            double notafinal;
            int contador = 0;

            while (contador < numberStudent)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota de su laboratorio 1: ");
                lab1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota de su laboratorio 2: ");
                lab2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la nota de su parcial: ");
                parcial = double.Parse(Console.ReadLine());

                notafinal = (lab1 * .3) + (lab2 * .3) + (parcial * .4);
                Console.WriteLine("Su nota final es: ");
                notafinal = double.Parse(Console.ReadLine());

                if (notafinal >= object && notafinal <= 10)
                {
                    if (notafinal >= 6)
                    {
                        Console.WriteLine("Aprobado");
                    }
                    else if (notafinal >= 4)
                    {
                        Console.WriteLine("Reprobado");
                    }
                }
                else
               

                contador++;

            }
            Console.WriteLine("====  Resultados ====");
            foreach (Students st in lista)
            {
                Console.WriteLine(st.getData());
            }

        }
    }
    public class Students
    {

        private string _nombre;
        private int _edad;
        private double _lab1;
        private double _lab2;
        private double _parcial;
        private double _notafinal;
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public double lab1
        {
            get => _lab1;
            set => _lab1 = value;
        }

        public double lab2
        {
            get => _lab2;
            set => _lab2 = value;
        }

        public double parcial
        {
            get => _parcial;
            set => _parcial = value;
        }

        public double NotaFinal
        {
            get => _notafinal;
            set => _notafinal = value;
        }

        public string getData()
        {
            return "Nombre: " + _nombre +  "edad: " + _edad +  "notafinal:" + _notafinal;
        }

    }
}
