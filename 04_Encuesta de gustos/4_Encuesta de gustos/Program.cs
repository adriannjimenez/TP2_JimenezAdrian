namespace _4_Encuesta_de_gustos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;
            string comida;
            Console.Clear();
            Console.Write("Ingrese su color favorito: ");
            color = Console.ReadLine();
            Console.Write("Ingrese su comida preferida: ");
            comida = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine($"Tu color favorito es {color} y tu comida favorita es {comida}.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
