using TextoEnAsteriscosConsola;

class Program
{
    static void Main(string[] args)
    {
        var graficador = new Graficador();

        Console.WriteLine("Ingrese un texto:");
        var entrada = Console.ReadLine();
        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("No se ingresó texto.");
            return;
        }
        var salida = graficador.ConvertirATexto(entrada);
        Console.WriteLine("\nResultado:\n");
        Console.WriteLine(salida);
    }
}
