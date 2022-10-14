using System;

namespace Punto2tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cAlumnos = 0, aPrivados = 0, aPublicos = 0, r;

            float porcentajePublic = 0f, porcentajePriv = 0f;


            bienvenida();

            do{
                Console.WriteLine("Ingrese 1 si va a una Escuela Publica");
                Console.WriteLine("Ingrese 2 si va a una Escuela Privada");
                Console.WriteLine("Ingrese 3 para salir del Programa");
                r = Convert.ToInt32(Console.ReadLine());

                switch(r)
                {
                    case 1:
                        aPublicos = aPublicos+1;
                        cAlumnos = cAlumnos+1;
                    break;

                    case 2:
                         aPrivados = aPrivados+1;
                         cAlumnos = cAlumnos+1;
                    break;
                }

                Console.Clear();

            } while(r == 1 || r == 2);

            Console.WriteLine("La cantidad de Estudiantes de una Escuela Publica son: {0} Estudiantes\n\n", aPublicos);

            porcentajePublic = (aPublicos * 100) / cAlumnos;

            Console.WriteLine("El Porcentaje de Estudiantes Privados en la Encuesta es de: {0} % \n\n", porcentajePublic);

            Console.WriteLine("--------------------------------------------------------------------------  \n\n");

            Console.WriteLine("La cantidad de Estudiantes de una Escuela Privada son: {0} Estudiantes\n\n", aPrivados);

            porcentajePriv = (aPrivados * 100) / cAlumnos;

            Console.WriteLine("El Porcentaje de Estudiantes Privados en la Encuesta es de: {0} %", porcentajePriv);

            Console.ReadKey();







        }

        static void bienvenida(){
            Console.WriteLine("Bienvenido al Programa Encuestador de Escuelas Privadas y Escuelas Publicas");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
