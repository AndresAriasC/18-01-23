using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEstudiante
{
    internal class Datos
    {
        private String nombre;
        private String matricula;
        private int nota;
        private int cEstu;

        public Datos() { }

        public void setNombre(string Nombre) {this.nombre = Nombre; }
        public void setMatricula(string Matricula) { this.matricula = Matricula; }

        public int Nota{ get;  set; }
        public int CEstu { get; set; }

        public int Validar(string Mensaje)
        {
            int Num = 0, v;

            do
            {
                v = 1;

                try
                {
                    Console.Write(Mensaje);
                    Num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;

                    Console.WriteLine("Digite un dato valido");
                }


            } while (v == 0);

            return Num;
        }
    }
}
