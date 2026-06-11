namespace _16_Plan_de_estudios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alumno;
            string asignatura;
            string profesor;
            Console.Clear();
            Console.Write("Ingrese el nombre del alumno: ");
            alumno = Console.ReadLine();
            Console.Write("Ingrese el nombre de la asignatura: ");
            asignatura = Console.ReadLine();
            Console.Write("Ingrese el nombre del profesor: ");
            profesor = Console.ReadLine();
            Console.WriteLine("----------------------");
            Console.WriteLine($"{alumno} cursa '{asignatura}' con {profesor}.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
