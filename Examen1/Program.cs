using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float horaEntrada, horaSalida, horasTrabajadas, pagoPorHora, pagoTotal;
            float horasExtras = 0, pagoExtra = 0;
            float LIMITE_HORAS = 40;
            double RECARGO = 1.5;

            Console.WriteLine("Por favor, usar formato de 24h");

            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Ingrese la hora de entrada: ");
            horaEntrada = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la hora de salida: ");
            horaSalida = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el pago por hora: ");
            pagoPorHora = float.Parse(Console.ReadLine());

            Console.Write("Ingrese las horas extras trabajadas: ");
            horasExtras = float.Parse(Console.ReadLine());

            horasTrabajadas = horaSalida - horaEntrada;
            if (horasTrabajadas > LIMITE_HORAS)
            {
                horasExtras = horasTrabajadas - LIMITE_HORAS;
                horasTrabajadas = LIMITE_HORAS;
                pagoExtra = horasExtras * pagoPorHora * (float)RECARGO;
            }

            pagoTotal = (horasTrabajadas * pagoPorHora) + pagoExtra;

            Console.WriteLine($"Empleado: {nombreEmpleado}");
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Horas extras: {horasExtras}");
            Console.WriteLine($"Pago total: {pagoTotal}");
            Console.WriteLine($"Las horas trabajadas en una semana fueron de {horasTrabajadas * 7}");


        }

    }
}
