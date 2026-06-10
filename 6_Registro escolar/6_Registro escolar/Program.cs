namespace _6_Registro_escolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            string materia;
            float notaFinal;
            Console.Clear();
            Console.Write("Ingrese el nombre del estudiante: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del estudiante: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese la materia: ");
            materia = Console.ReadLine();
            Console.Write("Ingrese la nota final: ");
            notaFinal = float.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.Write("Estudiante: {0} {1}", nombre, apellido);
            Console.Write(" - Materia: {0}", materia);
            Console.Write(" -Nota Final: {0}", notaFinal);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
