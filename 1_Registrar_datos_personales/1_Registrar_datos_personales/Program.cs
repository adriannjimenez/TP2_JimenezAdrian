namespace _1_Registrar_datos_personales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            byte edad;
            Console.Clear();
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Felicitaciones {0} {1}. Cumplirás {2} años", nombre, apellido, edad + 1);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
