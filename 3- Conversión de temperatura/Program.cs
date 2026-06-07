namespace _3__Conversión_de_temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ciudad;
            float tCelsius;
            float tFahrenheit;
            Console.Clear();
            Console.Write("Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();
            Console.Write("Ingrese la temperatura en Celsius: ");
            tCelsius = float.Parse(Console.ReadLine());
            tFahrenheit = (tCelsius * (9f / 5f)) + 32f;
            Console.WriteLine("----------------------");
            Console.WriteLine("En {0}, la temperatura es de {1}°C", ciudad, tCelsius);
            Console.WriteLine("que se corresponde a " + tFahrenheit + "ºF.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
