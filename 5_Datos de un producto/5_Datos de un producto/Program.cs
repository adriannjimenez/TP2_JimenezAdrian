namespace _5_Datos_de_un_producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string producto;
            float precio;
            Console.Clear();
            Console.Write("Ingrese el nombre de un producto: ");
            producto = Console.ReadLine();
            Console.Write("Ingrese su precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"El producto '{producto}' cuesta ${precio:F2}");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
