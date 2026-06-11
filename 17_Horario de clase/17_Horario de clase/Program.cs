namespace _17_Horario_de_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string horaInicio;
            float duracion;
            Console.Clear();
            Console.Write("Ingrese el día de la clase: ");
            dia = Console.ReadLine();
            Console.Write("Ingrese la hora de inicio (formato HH:MM AM/PM): ");
            horaInicio = Console.ReadLine();
            Console.Write("Ingrese la duración en horas: ");
            duracion = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Clase el {dia} a las {horaInicio}, duración: {duracion} horas");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
