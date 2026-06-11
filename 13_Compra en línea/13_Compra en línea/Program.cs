namespace _13_Compra_en_línea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            string producto;
            int cantidad;
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente: ");
            cliente = Console.ReadLine();
            Console.Write("Ingrese el nombre del producto: ");
            producto = Console.ReadLine();
            Console.Write("Ingrese la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"{cliente} compró {cantidad} unidades de {producto}");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
