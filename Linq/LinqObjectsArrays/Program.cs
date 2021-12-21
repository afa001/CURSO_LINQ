using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectsArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ WITH ARRAYS

            Console.WriteLine("TIPOS DE DATOS IMPLICITOS");

            //EJERCICIO 1
            int[] numbersArray = { 1, 2, 3, 4, 5, 6 };
            var lstNumbersArray = from number in numbersArray
                                 where number > 2
                                 select number;

            //var s = numbersArray.Where(x => x > 2);

            foreach (var numberArray in lstNumbersArray)
            {
                Console.WriteLine(numberArray);
            }
            // Output: 3 4 5 6

            Console.WriteLine("Muestra de EJECUCION DIFERIDA, modificamos el arreglo numbersArray para agregar un valor 12 linq por defecto vuelve a ejecutar el query sin tener que hacerlo por nuestra cuenta");
            numbersArray[1] = 12;

            foreach (var numberArray in lstNumbersArray)
            {
                Console.WriteLine(numberArray);
            }
            // Output: 12 3 4 5 6

            Console.WriteLine("Muestra de EJECUCION INMEDIATA, modificamos el arreglo numbersArray para agregar un valor 28 linq no toma por defecto el valor actualizado y tendremos que volver a ejecutar el query para que se vea reflejado la actualizacion del arreglo numbersArray");

            var lstNumbersArrayEI = (from number in numbersArray
                                     where number > 2
                                     select number).ToArray<int>();  //Agregamos el numbersArray object dentro de otro array creando un nuevo object

            numbersArray[0] = 28;

            foreach (var item in lstNumbersArrayEI)
            {
                Console.WriteLine(item);
            }


            //EJERCICIO 2
            string[] dessertArray = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresa con crema" };
            var lstDessert = from dessert in dessertArray
                             where dessert.Contains("manzana")
                             select dessert;

            //var lstDessert = dessertArray.Where(desert => desert.Contains('manzana'));

            foreach (string dessert in lstDessert)
            {
                Console.WriteLine(dessert);
            }
            // Output: pay de manzana
            // manzana caramelizada

            Console.WriteLine("TIPOS DE DATOS EXPLICITOS");

            //EJERCICIO 1 
            int[] numbers = { 1, 5, 7, 3, 5, 9, 8 };
            IEnumerable<int> lstNumbers = from number in numbers 
                                      select number;

            foreach (var number in lstNumbers)
            {
                Console.WriteLine(number);
            }
            // Output: 1 5 7 3 5 9 8 


            //EJERCICIO 2
            int[] values = { 1, 5, 7, 3, 5, 9, 8 };
            IEnumerable<int> lstValues = from value in values
                                               where value > 3 && value < 8
                                               select value;

            foreach (var value in lstValues)
            {
                Console.WriteLine(value);
            }
            // Output: 5 7 5 


            //EJERCICIO 3
            string[] postres = { "pay de manzana" , "pastel de chocolate", "manzana caramelizada","fresa con crema"};
            IEnumerable<string> lstPostres = from postre in postres
                                                     where postre.Contains("manzana")
                                                     select postre;

            foreach (string postre in lstPostres)
            {
                Console.WriteLine(postre);
            }
            // Output: pay de manzana
            // manzana caramelizada
     
            Console.ReadLine();
        }

    }
}
