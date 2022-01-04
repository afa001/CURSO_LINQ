using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectsList.Model
{
    internal class Student
    {
        public string Nombre { get; set; }
        public string Id { get; set; }

        public string Curso { get; set; }

        public double Promedio { get; set; }

        public Student(string pNombre, string pId, string pCurso, double pPromedio)
        {
            Nombre = pNombre;
            Id = pId;
            Curso = pCurso;
            Promedio = pPromedio;
        }

        //public override string ToString()
        //{
        //    return string.Format("Nombre: {0}, {1}, Curso: {2}, Promedio:{3}",Nombre,Id,Curso,Promedio);
        //}
    }
}
