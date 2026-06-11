namespace _11_Encuesta_de_mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipoMascota;
            string nombre;
            byte edad;
            Console.Clear();
            Console.Write("Ingrese el tipo de mascota: ");
            tipoMascota = Console.ReadLine();
            Console.Write("Ingrese el nombre de la mascota: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese la edad de la mascota: ");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine($"Tu mascota {nombre} es un {tipoMascota} y tiene {edad} años de edad.");
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar!");
            Console.ReadKey();
        }
    }
}
