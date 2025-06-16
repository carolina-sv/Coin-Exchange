
using System;
using CoinExchange.Helper;

double dolar = 5.54;
double euro = 6.36;
double libra = 7.50;
double iene = 26.13;
double valorConvertido = 0;
double valorReais;

// --- SISTEMA EM LOOPING
Console.WriteLine("BEM VINDO AO CONVERSOR DE MOEDAS. Escolha um número");
Console.WriteLine("1-Deu bom");
Console.WriteLine("2-Deu bom");
Console.WriteLine("3-Sair");


var entradaSistema = Console.ReadLine();

do
{
    Console.WriteLine("BEM VINDO AO CONVERSOR DE MOEDAS. Escolha um número");
    Console.WriteLine("1-Deu bom");
    Console.WriteLine("2-Deu bom");
    Console.WriteLine("3-Sair");
    entradaSistema = Console.ReadLine();
}
while (entradaSistema  != "3");








//while (true)
//{
//    Console.WriteLine("Digite o valor em reais (R$):");
//    string entradaValor = Console.ReadLine();


//    if (double.TryParse(entradaValor, out valorReais))
//    {
//        if (valorReais > 0 && valorReais < 100000)
//        {
//            Console.WriteLine($"Você digitou R$ {valorReais:F2}");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("O valor deve ser maior que 0 e menor que 100.000.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Valor inválido. Digite um número válido.");
//    }
//}

////Validação da moeda escolhida 💱

//string entradaMoeda;

//while (true)
//{
//    Console.WriteLine("Para qual moeda você deseja converter? 💵dolar, 💶euro, 💷libra ou 💴iene");
//    entradaMoeda = Console.ReadLine()?.ToLower().Trim();

    
//    if (!string.IsNullOrWhiteSpace(entradaMoeda) &&
//        entradaMoeda.All(char.IsLetter) &&
//        (entradaMoeda == "dolar" || entradaMoeda == "euro" || entradaMoeda == "libra" || entradaMoeda == "iene"))
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Moeda inválida. Digite apenas letras e escolha entre: dolar, euro, libra ou iene.");
//    }
//}

//switch (entradaMoeda)
//{
//    case "dolar":
//        valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, dolar);
//        Console.WriteLine($"O valor em Dólar é 💵${valorConvertido:F2}");
//        break;

//    case "euro":
//        valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, euro);
//        Console.WriteLine($"O valor em Euro é 💶€{valorConvertido:F2}");
//        break;

//    case "libra":
//        valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, libra);
//        Console.WriteLine($"O valor em Libra é 💷£{valorConvertido:F2}");
//        break;

//    case "iene":
//        valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, iene);
//        Console.WriteLine($"O valor em Iene é 💴¥{valorConvertido:F2}");
//        break;

//    default:
//        Console.WriteLine("Moeda não encontrada!");
//        break;
//}
