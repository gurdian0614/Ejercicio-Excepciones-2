
using Ejercicio_Excepciones_2;

try
{
    double a, b, c;
    string sa, sb, sc;
    FormulaCuadratica fm = new FormulaCuadratica();

    Console.WriteLine("Ingrese valor a:");
    sa = Console.ReadLine();
    if (double.TryParse(sa, out a) == true)
    {
        fm.A = a;
        Console.WriteLine("Ingrese valor b:");
        sb = Console.ReadLine();

        if (double.TryParse(sb, out b) == true)
        {
            fm.B = b;
            Console.WriteLine("Ingrese valor c:");
            sc = Console.ReadLine();
            if (double.TryParse(sc, out c) == true)
            {
                fm.C = c;
                Console.WriteLine(fm.Calcular());
            } else
            {
                Console.WriteLine($"{sc} no es un valor numérico");
            }
        }
        else
        {
            Console.WriteLine($"{sb} no es un valor numérico");
        }
    } else
    {
        Console.WriteLine($"{sa} no es un valor numérico");
    }
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}