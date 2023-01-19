

namespace EjemploEstudiante;
using System;
class Program { 

    static void Main(string[] args)
    {
        int suma, a;

        Datos d = new Datos();
        d.CEstu = d.Validar("Ingrese la cantidad de estudiantes ");

        for (int i = 0; i < d.CEstu; i++)
        {
            suma = 0;
            Console.WriteLine("Estudiante #" + (i+1));
            Console.Write("Digite su nombre: ");
            d.setNombre(Console.ReadLine());
            Console.Write("Digite el numero de matricula: ");
            d.setMatricula(Console.ReadLine());
            //se recorre con un for las notas

            for (int j = 0; i < 4; j++)
            {
                do
                {
                    d.Nota = d.Validar("Ingresa la nota #" + (j + 1) + " en el rango de 0 a 25: ");
                    suma += d.Nota;
                    a = suma;
                    break;

                } while (d.Nota < 1 || d.Nota > 25);
                Console.WriteLine("Sumatoria con la nota anterior " + a);

                if (suma < 60)
                {
                    Console.WriteLine("REPROBADO");
                }
                else Console.WriteLine("APROBADO");
            }



        }


    }
}
