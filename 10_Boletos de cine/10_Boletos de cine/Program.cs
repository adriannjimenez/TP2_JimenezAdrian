namespace _10_Boletos_de_cine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cliente;
            byte cantBoletos;
            float precioBoleto = 0.00f;
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente: ");
            cliente = Console.ReadLine();
            Console.Write("Ingrese la cantidad de boletos: ");
            cantBoletos = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio del boleto: ");
            precioBoleto = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("{0} compró {1} boletos a ${2:F2} cada uno", cliente, cantBoletos, precioBoleto);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
