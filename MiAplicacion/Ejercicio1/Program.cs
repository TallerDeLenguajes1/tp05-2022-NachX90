Console.WriteLine("INVERSOR DE NÚMEROS MAYORES A CERO");
Console.Write("Ingrese el número a invertir: ");
int numeroAInvertir = int.Parse(Console.ReadLine());
if (numeroAInvertir <= 0)
{
    Console.WriteLine("El número ingresado es cero o negativo. No se invertirá.");
}
else
{
    int numeroInvertido=0;
    while (numeroAInvertir > 0)
    {
        numeroInvertido = numeroInvertido * 10 + (numeroAInvertir % 10);
        numeroAInvertir /= 10;
    }
    Console.WriteLine("El número invertido es: " + numeroInvertido);
}