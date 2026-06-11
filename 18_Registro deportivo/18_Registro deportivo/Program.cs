namespace _18_Registro_deportivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jugador;
            string deporte;
            int puntaje;
            Console.Clear();
            Console.Write("Ingrese el nombre del jugador: ");
            jugador = Console.ReadLine();
            Console.Write("Ingrese el nombre del deporte: ");
            deporte = Console.ReadLine();
            Console.Write("Ingrese el puntaje del jugador: ");
            puntaje = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Jugador {jugador} - Deporte: {deporte} - Puntaje: {puntaje}");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
