namespace _7_InformacionDeContacto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string mail;
            string telefono;
            Console.Clear();
            Console.Write("Ingrese el nombre del contacto: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el correo electrónico del contacto: ");
            mail = Console.ReadLine();
            Console.Write("Ingrese el número de teléfono del contacto: ");
            telefono = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Usuario: {0} - Email: {1} - Teléfono: {2}", nombre, mail, telefono);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
