Console.WriteLine("CALCULADORA V2.1");
int opcion, seguir = 0;
float numero1 = 0, numero2 = 0;
do
{
    do
    {
        Console.WriteLine("\n\t1: Suma\n\t2: Resta\n\t3: Producto\n\t4: Cociente\n\t5: Omitir operación");
        Console.Write("Ingrese la operación a realizar: ");
        opcion = int.Parse(Console.ReadLine());
    } while (opcion < 1 && opcion > 5);
    if (opcion != 5)
    {
        Console.Write("Escriba el primer numero: ");
        numero1 = float.Parse(Console.ReadLine());
        Console.Write("Escriba el segundo numero: ");
        numero2 = float.Parse(Console.ReadLine());
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"\nEl resultado de la suma {numero1} + {numero2} es: " + (numero1 + numero2));
            break;
        case 2:
            Console.WriteLine($"\nEl resultado de la resta {numero1} - {numero2} es: " + (numero1 - numero2));
            break;
        case 3:
            Console.WriteLine($"\nEl resultado del producto {numero1} * {numero2} es: " + (numero1 * numero2));
            break;
        case 4:
            if (numero2 == 0)
            {
                Console.WriteLine("\nIndefinido. No se puede dividir en cero");
            }
            else
            {
                Console.WriteLine($"\nEl resultado del cociente {numero1} / {numero2} es: " + (numero1 / numero2));
            }
            break;
        default:
            break;
    }
    if (opcion != 5)
    {
        Console.Write("\nDesea hacer otra operacion? (presione 1 para si, cualquier otro número para no): ");
        seguir = int.Parse(Console.ReadLine());
    }
} while (seguir == 1);

Console.Write("\nEscriba un número: ");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine($"\tEl valor abosluto de {numero1} es:\t" + Math.Abs(numero1));
Console.WriteLine($"\tEl cuadrado de {numero1} es:\t\t" + Math.Pow(numero1, 2));
Console.WriteLine($"\tLa raiz cuadrada de {numero1} es:\t" + Math.Sqrt(numero1));
Console.WriteLine($"\tEl seno de {numero1} es:\t\t" + Math.Sin(numero1));
Console.WriteLine($"\tEl coseno de {numero1} es:\t\t" + Math.Cos(numero1));
Console.WriteLine($"\tLa parte entera de {numero1} es:\t" + Math.Truncate(numero1));
Console.WriteLine("\nEscriba dos números:");
Console.Write("\tPrimer número: ");
numero1 = float.Parse(Console.ReadLine());
Console.Write("\tSegundo número: ");
numero2 = float.Parse(Console.ReadLine());
Console.WriteLine($"\t\tEl máximo entre {numero1} y {numero2} es:\t" + Math.Max(numero1, numero2));
Console.WriteLine($"\t\tEl mínimo entre {numero1} y {numero2} es:\t" + Math.Min(numero1, numero2));
Console.WriteLine("\nGracias por utilizar. Vuelva pronto.");
