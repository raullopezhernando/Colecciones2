using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Program
    {
        static void Main(string[] args)
        {

            //// INICIO DE SORTEDLIST<T>

            //SortedList<string, string> nombres = new SortedList<string, string>();

            //nombres.Add("Z", "Zack");
            //nombres.Add("A", "Alberto");
            //nombres.Add("H", "Hector");
            //nombres.Add("B", "Braulio");

            //// Automaticamente y sin haber puesto nada se ordenan
            //// automaticamente las keys automaticamente de hay el
            //// nombre de SortedList
            //foreach (var elemento in nombres) {

            //    string inicial = elemento.Key;
            //    string nombre = elemento.Value;

            //    Console.WriteLine($"{inicial},{nombre}");
            //}

            //FINAL DE SORTED LIST



            //    // INICIO DE HASH SET <T>

            //    // Lo bueno de esta coleccion es que puedes comparar cadenas de datos con sus metodos. Ejemplos

            //    // Si imaginamos que tenemos dos HashSet diferentes con
            //    // asignaturas en cada licenciatura los siguientes metodos nos permitiran ...

            //   // Licenciatura1.UnionWith(Licenciatura2); --- Juntar ambas cadenas teniendo las asignaturas de ambas licenciaturas en una sola
            //   // Licenciatura1.IntersectWith(Licenciatura2); --- Genera una licenciatura con las aignaturas que estan en ambas cadenas
            //   // Licenciatura1.ExceptWith(Licenciatura2); --- Genera una licenciatura en la que se encuentran las asignaturas no coincidentes


            //    HashSet<string> Licenciatura1= new HashSet<string>();

            //    Licenciatura1.Add("Cocina");
            //    Licenciatura1.Add("Negocios");
            //    Licenciatura1.Add("Programacion");
            //    Licenciatura1.Add("Postres");

            //    HashSet<string> Licenciatura2 = new HashSet<string>(new String []{ "Programacion","Algoritmos","Postres","BD"});



            //    foreach (var elemento in Licenciatura1) 
            //    {
            //        Console.WriteLine(elemento); 
            //    }

            //    Console.WriteLine();

            //    Licenciatura1.UnionWith(Licenciatura2);
            //    Licenciatura1.IntersectWith(Licenciatura2);
            //    Licenciatura1.ExceptWith(Licenciatura2);


            //    foreach (var elemento in Licenciatura1)
            //    {
            //        Console.WriteLine(elemento);
            //    }

            //    Console.ReadLine();
            //}

            //// FINAL DE COLECCION HASHSET
            ///

            //INICIALIZACION DE COLECCIONES . Ejemplos

            // Esta inicializacion solo sirve para aquellas colecciones que utilizan "Add" por esta razon no sirve para las
            // colecciones Queue y Stack.

            List<string> elementos = new List<string>
            {
                "Hector",
                "Ricardo",
                "Juan"
            };

            // Para colecciones que utilizan key y valor se utiliza ....

            Dictionary<int, int> diccionario = new Dictionary<int, int>()
            {
                [0] = 1,
                [1] = 2,
                [2] = 3

            };

            // Inicializacion clave/valor de tipo anonimo

            Dictionary<string, string> diccionario2 = new Dictionary<string, string>()
            {

                { "Raulito","Raul Cantalapiedra"},
                {"Itxasito ", "Itxaso Valdeparejo"}
            };

          

        }
    }
}
