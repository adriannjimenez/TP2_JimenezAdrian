namespace _01_Registrar_datos_personales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            byte edad;
            Console.Clear();
            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Felicitaciones {0} {1}. Tienes {2} años", nombre, apellido, edad);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
