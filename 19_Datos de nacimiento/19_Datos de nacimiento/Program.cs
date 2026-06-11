namespace _19_Datos_de_nacimiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte dia;
            byte mes;
            int año;
            Console.Clear();
            Console.Write("Ingrese el día de nacimiento: ");
            dia = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes de nacimiento: ");
            mes = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese el año de nacimiento: ");
            año = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Fecha de nacimiento: {0}/{1}/{2}", dia, mes, año);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
