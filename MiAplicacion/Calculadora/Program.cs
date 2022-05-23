Console.WriteLine("CALCULADORA V1.0");
string seguir;
do
{
    string opcion;
    do
    {
        Console.WriteLine("\n\t1: Suma\n\t2: Resta\n\t3: Producto\n\t4: Cociente");
        Console.Write("Ingrese la operacion a realizar: ");
        opcion = Console.ReadLine();
    } while (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4");
    Console.Write("Escriba el primer numero: ");
    int numero1 = int.Parse(Console.ReadLine());
    Console.Write("Escriba el segundo numero: ");
    int numero2 = int.Parse(Console.ReadLine());
    switch (opcion){
        case "1":
            Console.WriteLine($"\nEl resultado de la suma {numero1} + {numero2} es: " + (numero1 + numero2));
            break;
        case "2":
            Console.WriteLine($"\nEl resultado de la resta {numero1} - {numero2} es: " + (numero1 - numero2));
            break;
        case "3":
            Console.WriteLine($"\nEl resultado del producto {numero1} * {numero2} es: " + (numero1 * numero2));
            break;
        case "4":
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
    Console.Write("\nDesea hacer otra operacion? (presione 1 para si, cualquier otra tecla para no): ");
    seguir = Console.ReadLine();
} while (seguir == "1");
Console.WriteLine("Gracias por utilizar. Vuelva pronto.");
