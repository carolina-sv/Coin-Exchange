// --- Taxa Fixa de conversão
double dolar = 5.54;
double euro = 6.36;
double valorConvertido = 0;

// --- Perguntar o usuário o valor
Console.WriteLine("Digite o valor em reais(R$):");
string entradaValor = Console.ReadLine();

// --- Casting ==> convertendo string to double
double valorReais = Convert.ToDouble(entradaValor);

// ----------------------------------------------------
// --- RN1: O valor digitado tem que ser maior que zero
// ----------------------------------------------------
if(valorReais <= 0)
{
    Console.WriteLine("O valor digitado tem que ser maior que zero!");
    return;
}

// --- Perguntar o usuário o valor
Console.WriteLine("Para qual moeda você deseja converter (dolar ou euro)");
string entradaMoeda = Console.ReadLine();

if(entradaMoeda == "dolar")
{
    valorConvertido = valorReais / dolar;
    Console.WriteLine($"O valor em dolar é ${valorConvertido:F2}");
    return;
}
else if (entradaMoeda == "euro")
{
    valorConvertido = valorReais / euro;
    Console.WriteLine($"O valor em Euro é €{valorConvertido:F2}");
    return;
} else
{
    Console.WriteLine($"Moeda não encontrada!");
    return;
}
