using System.Data;
string cadena1, cadena2;

Console.WriteLine("EJERCICIO 4");
do
{
    Console.Write("\nIngrese una oración (al menos 10 caracteres): ");
    cadena1 = Console.ReadLine();
} while (cadena1.Length < 10);
do
{
    Console.Write("Ingrese otra oración (al menos 10 caracteres): ");
    cadena2 = Console.ReadLine();
} while (cadena2.Length < 10);
Console.WriteLine("\nEl segundo caracter de la primera oración es \"" + cadena1[1] + "\" y el sexto es \"" + cadena1[5] + "\"");
Console.WriteLine("La longitud de la primera oración es: " + cadena1.Length);
Console.WriteLine("La oración 1 concatenada con la oración 2 queda: " + string.Concat(cadena1, cadena2));
Console.WriteLine("La subcadena extraída de la primera oración es: \"" + cadena1.Substring(5) + "\"");
//La operación binaria representada con texto está hecha en el problema 2 original del TP.
Console.WriteLine("Los caracteres de la primera oración son:");
foreach (char caracter in cadena1)
{
    Console.WriteLine("\t" + caracter);
}
Console.WriteLine("La primera oración contiene la palabra \"hola\"?: " + cadena1.Contains("hola"));
Console.WriteLine("La primera oración en mayúsculas es: " + cadena1.ToUpper());
Console.WriteLine("La primera oración en minúsculas es: " + cadena1.ToLower());
Console.WriteLine("Las oraciones comparadas devuelve: " + string.Compare(cadena1, cadena2));
do
{
    Console.Write("\nIngrese una oración que contenga al menos 1 \"+\": ");
    cadena1 = Console.ReadLine();
} while (!cadena1.Contains("+"));
string[] arreglo = cadena1.Split("+");
Console.WriteLine("Las partes de la oración separada son:");
foreach (string parte in arreglo)
{
    Console.WriteLine("\t" + parte);
}
Console.Write("Escriba una ecuación binaria con \"+\", \"-\", \"*\" ó \"/\": ");
cadena1 = Console.ReadLine();
float resultado = (float)Convert.ToDouble(new DataTable().Compute(cadena1, null));
Console.WriteLine($"El resultado de {cadena1} es: {resultado}");
Console.WriteLine("\nGracias por utilizar. Vuelva pronto.");
