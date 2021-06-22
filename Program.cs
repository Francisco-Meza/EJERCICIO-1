using System;

namespace EJERCICIO_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[10];//-- ARREGLO QUE GUARDARA LOS DATOS
            Numeros numeros = new Numeros(datos);//-- INSTANCIO EL OBJETO
            for (int i = 0; i < datos.Length; i++)//-- GUARDA LOS DATOS EN EL ARREGLO 
            {
                Console.WriteLine("------- ESTE PROGRAMA ES DE AYUDA MULTIPLE CON 10 NUMEROS-------------\n");
                Console.Write($"Escriba el numero{(i + 1)}: ");
                datos[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("------- ESTE PROGRAMA ES DE AYUDA MULTIPLE CON 10 NUMEROS-------------\n");
            Console.WriteLine("Escoge cual opciones ocupas: ");
            Console.WriteLine("a) La sumatoria de los 10 elementos.        b)El promedio de los elementos leídos.");
            Console.WriteLine("c)El número más grande de los números leídos. d)El número más pequeño de los números leídos");
            char ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            switch (ans)//-- VALORA EN INCISO INTRODUCIDO
            {
                case 'A': Console.WriteLine(numeros.Suma()); break;
                case 'B': Console.WriteLine(numeros.Promedio()); break;
                case 'C':
                    {
                        int[] Ians = numeros.Ordenar();
                        Console.WriteLine(Ians[0]);
                        break;
                    }
                case 'D':
                    {
                        int[] Ians = numeros.Ordenar();
                        Console.WriteLine(Ians[9]);
                        break;
                    }
                default: Console.WriteLine("No existe esta opcion seleccionada"); break;
            }
        }
    }
}
