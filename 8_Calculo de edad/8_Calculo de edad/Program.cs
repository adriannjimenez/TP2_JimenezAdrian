namespace _8_Calculo_de_edad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int añoActual;
            int añoNacimiento;
            Console.Clear();
            Console.Write("Ingrese el año actual: ");
            añoActual = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año de nacimiento: ");
            añoNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"El año actual es {añoActual} y tu año de nacimiento es {añoNacimiento}");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
