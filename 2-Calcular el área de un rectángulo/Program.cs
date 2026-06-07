namespace _2_Calcular_el_área_de_un_rectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado_base;
            float altura;
            float area;
            Console.Clear();
            Console.WriteLine("CÁLCULO DEL ÁREA DE UN RECTÁNGULO");
            Console.WriteLine("CUIDADO: El punto decimal es la coma \",\"");
            Console.WriteLine();
            Console.Write("Ingrese la medida de la BASE [cm]: ");
            lado_base = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese la medida de la ALTURA [cm]: ");
            altura = float.Parse(Console.ReadLine());
            area = lado_base * altura;
            Console.WriteLine("------------------------------");
            Console.WriteLine("EL valor de la base es " + lado_base + " cm.");
            Console.WriteLine("EL valor de la altura es " + altura + " cm.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("El área es igual a {0} cm^2:",area);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
