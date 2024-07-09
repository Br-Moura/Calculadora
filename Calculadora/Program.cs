Console.WriteLine("Calculadora Simples");

double n1, n2;
int result = 0;

Console.WriteLine("Insira o primeiro numero");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo numero");
n2 = double.Parse(Console.ReadLine());

Console.Clear();

while (result != 5)
{
    Console.WriteLine("para somar digite 1");
    Console.WriteLine("para subitrair digite  2");
    Console.WriteLine("para multiplicar digite 3");
    Console.WriteLine("para dividir digite 4");
    result = int.Parse(Console.ReadLine());
    Console.Clear();
    if (result == 1)
    {
        Console.WriteLine("Soma = {0}", n1 + n2);
        break;
    }
    else if (result == 2)
    {
        Console.WriteLine("Subitrair = {0}", n1 - n2);
        break;
    }
    else if (result == 3)
    {
        Console.WriteLine("Multiplica = {0}", n1 * n2);
        break;
    }
    else if (result == 4)
    {
        Console.WriteLine("Dividir = {0}", n1 / n2);
        break;
    }
    else{
        Console.WriteLine("Selecione um operador");
    }
}