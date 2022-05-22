Console.WriteLine("INVERSOR DE NUMEROS MAYORES A CERO");
Console.WriteLine("Ingrese el numero a invertir:");
int numeroAInvertir = int.Parse(Console.ReadLine());
if (numeroAInvertir <= 0)
{
    Console.WriteLine("El numero es cero o negativo. No se invertira.");
}
else
{
    int numeroInvertido=0;
    while (numeroAInvertir > 0)
    {
        numeroInvertido = numeroInvertido * 10 + (numeroAInvertir % 10);
        numeroAInvertir /= 10;
    }
    Console.WriteLine("El numero invertido es: "+numeroInvertido);
}