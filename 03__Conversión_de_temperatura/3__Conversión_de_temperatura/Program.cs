namespace _3__Conversión_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciudad;
            float tCelsius;
            Console.Clear();
            Console.Write("Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();
            Console.Write("Ingrese la temperatura en Celsius: ");
            tCelsius = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("En {0}, la temperatura es de {1}°C", ciudad, tCelsius);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
