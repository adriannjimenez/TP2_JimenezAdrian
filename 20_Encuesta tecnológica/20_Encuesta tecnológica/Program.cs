namespace _20_Encuesta_tecnológica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sistemaOperativo;
            string dispositivo;
            Console.Clear();
            Console.Write("Ingrese el nombre del sistema operativo preferido: ");
            sistemaOperativo = Console.ReadLine();
            Console.Write("Ingrese el dispositivo (PC/Laptop/Tablet): ");
            dispositivo = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Prefieres {0} y usas {1}", sistemaOperativo, dispositivo);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
