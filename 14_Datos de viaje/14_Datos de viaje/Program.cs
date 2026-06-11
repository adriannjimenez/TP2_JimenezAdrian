namespace _14_Datos_de_viaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destino;
            float distancia;
            float tiempo;
            Console.Write("Ingrese el destino del viaje: ");
            destino = Console.ReadLine();
            Console.Write("Ingrese la distancia del viaje en kilómetros: ");
            distancia = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el tiempo estimado del viaje en horas: ");
            tiempo = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Viaje a {destino} - {distancia} km - Tiempo estimado: {tiempo} horas");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
