namespace _9_Ingreso_de_coordenadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte valorX;
            sbyte valorY;
            Console.Clear();
            Console.Write("Ingrese el valor en X: ");
            valorX = sbyte.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor en Y: ");
            valorY = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Las coordenadas ingresadas son ({0}, {1})", valorX, valorY);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
