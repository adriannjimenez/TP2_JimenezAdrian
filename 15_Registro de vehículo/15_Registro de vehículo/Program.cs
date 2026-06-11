namespace _15_Registro_de_vehículo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            string modelo;
            int año;
            Console.Clear();
            Console.Write("Ingrese la marca del vehículo: ");
            marca = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehículo: ");
            modelo = Console.ReadLine();
            Console.Write("Ingrese el año del vehículo: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Vehículo registrado: {marca} {modelo} - Año: {año}");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
