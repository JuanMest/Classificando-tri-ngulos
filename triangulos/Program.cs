Console.Write("Digite o primeiro lado do triângulo: ");
double n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo lado do triângulo: ");
double n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro lado do triângulo: ");
double n3 = Convert.ToDouble(Console.ReadLine());

if(n1 + n2 > n3 && n2 + n3 > n1 && n3 + n1 > n2)
{
    if(n1 == n2 && n2 == n3)
    {
        Console.WriteLine("Esse triângulo é Equilátero");
    }

    else if(n1 == n2 || n2 == n3 || n3 == n1)
    {
        Console.WriteLine("Esse triângulo é Isósceles");
    }

    else
    {
        Console.WriteLine("Esse triângulo é Escaleno");
    }
}

else
{
    Console.WriteLine("Os valores fornecidos não formam um triângulo");
}
