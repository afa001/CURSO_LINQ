using LinqObjectsList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ WITH LIST


            //where, orderby

            List<Student> lstStudent = new List<Student>
            {
                new Student("Ana", "A100", "Mercadotecnia", 10.0),
                new Student("Luis", "S250", "Orientado a objetos", 9.0),
                new Student("Juan", "S875", "Programacion basica", 5.0),
                new Student("Susana", "A432", "Mercadotecnia", 8.7),
                new Student("Pablo", "A156", "Mercadotecnia", 4.3),
                new Student("Alberto", "S456", "Orientado a objetos", 8.3)
            };

            var failedStudents = from student in lstStudent
                                 where student.Promedio <= 5.0
                                 orderby student.Promedio descending
                                 select student;

            foreach (var failedStudent in failedStudents)
                Console.WriteLine(string.Format("Nombre: {0}, {1}, Curso: {2}, Promedio:{3}", failedStudent.Nombre, failedStudent.Id, failedStudent.Curso, failedStudent.Promedio));
            Console.ReadLine();

            //Output
            //Nombre: Juan, S875, Curso: Programacion basica, Promedio:5
            //Nombre: Pablo, A156, Curso: Mercadotecnia, Promedio: 4,3


            //group by

            List<Student> lstStudents = new List<Student>
            {
                new Student("Ana", "A100", "Mercadotecnia", 10.0),
                new Student("Luis", "S250", "Orientado a objetos", 9.0),
                new Student("Juan", "S875", "Programacion basica", 5.0),
                new Student("Susana", "A432", "Mercadotecnia", 8.7),
                new Student("Pablo", "A156", "Mercadotecnia", 4.3),
                new Student("Alberto", "S456", "Orientado a objetos", 8.3)
            };

            var groupedResult = from student in lstStudents
                                where student.Promedio >= 5.1
                                orderby student.Nombre
                                group student by student.Curso;

            foreach (var approvedStudents in groupedResult)
            {
                Console.WriteLine("Curso: {0}", approvedStudents.Key);

                foreach (var student in approvedStudents)
                {
                    Console.WriteLine(string.Format("Nombre: {0}, Promedio: {1}, Curso: {2}", student.Nombre, student.Promedio, student.Curso));
                }
            }
            Console.ReadLine();

            //Output
            //Curso: Orientado a objetos
            //Nombre: Alberto, Promedio: 8,3, Curso: Orientado a objetos
            //Nombre: Luis, Promedio: 9, Curso: Orientado a objetos

            //Curso: Mercadotecnia
            //Nombre: Ana, Promedio: 10, Curso: Mercadotecnia
            //Nombre: Susana, Promedio: 8,7, Curso: Mercadotecnia


            //OfType

            List<Object> mixedList = new List<object>();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student("Ana", "A100", "Mercadotecnia", 10.0));
            mixedList.Add(new Student("Juan", "S875", "Programacion basica", 5.0));

            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            var studentResult = from s in mixedList.OfType<Student>()
                            select s;

            foreach (var str in stringResult)
                Console.WriteLine(str);

            foreach (var integer in intResult)
                Console.WriteLine(integer);

            foreach (var student in studentResult)
                Console.WriteLine(student.Nombre);
            Console.ReadLine();

            //Output
            //One
            //Two
            //0
            //3
            //Ana
            //Juan
        }
    }
}