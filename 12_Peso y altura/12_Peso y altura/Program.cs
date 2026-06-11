namespace _12_Peso_y_altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso;
            float altura;
            Console.Clear();
            Console.Write("Ingrese el peso en kg: ");
            peso = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura en metros: ");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Tienes un peso de {peso} kg y una altura de {altura} m");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
