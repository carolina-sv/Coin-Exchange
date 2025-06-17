using CoinExchange.Helper;

double dolar = 5.54;
double euro = 6.36;
double libra = 7.50;
double iene = 26.13;


while (true)
{
    double valorReais = 0;

    // --- Entrada do valor
    while (true)
    {
        Console.WriteLine("Digite o valor em reais (R$) \nou digite sair para encerrar:");
        string entradaValor = Console.ReadLine();

        if (entradaValor.ToUpper() == "SAIR")
        {
            Console.WriteLine("Encerrando o programa...");
            break;
        }

        if (double.TryParse(entradaValor, out valorReais))
        {
            if (valorReais > 0 && valorReais < 100000)
            {
                Console.WriteLine($"✅ Você digitou R$ {valorReais:F2}");
                break;
            }
            else
            {
                Console.WriteLine("⚠️ O valor deve ser maior que 0 e menor que 100.000.");
            }
        }
        else
        {
            Console.WriteLine("⚠️ Valor inválido. Digite um número válido.");
        }
    }

    if (valorReais == 0)
        break;

    // --- Escolha da moeda
    string entradaMoeda = "";

    while (true)
    {
        Console.WriteLine("\nPara qual moeda você deseja converter?");
        Console.WriteLine("Digite: 💵 dolar | 💶 euro | 💷 libra | 💴 iene");
        Console.WriteLine("Ou digite 2 para sair:");
        entradaMoeda = Console.ReadLine()?.ToLower().Trim();

        if (entradaMoeda == "2")
        {
            Console.WriteLine("Programa encerrado ⚠️");
            break;
        }

        if (!string.IsNullOrWhiteSpace(entradaMoeda) &&
            entradaMoeda.All(char.IsLetter) &&
            (entradaMoeda == "dolar" || entradaMoeda == "euro" || entradaMoeda == "libra" || entradaMoeda == "iene"))
        {
            double valorConvertido = 0;

            switch (entradaMoeda)
            {
                case "dolar":
                    valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, dolar);
                    Console.WriteLine($"💵 Em Dólar: ${valorConvertido:F2}");
                    break;

                case "euro":
                    valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, euro);
                    Console.WriteLine($"💶 Em Euro: €{valorConvertido:F2}");
                    break;

                case "libra":
                    valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, libra);
                    Console.WriteLine($"💷 Em Libra: £{valorConvertido:F2}");
                    break;

                case "iene":
                    valorConvertido = new ConvertFunction().ConverterMoeda(valorReais, iene);
                    Console.WriteLine($"💴 Em Iene: ¥{valorConvertido:F2}");
                    break;
            }

            break;
        }
        else
        {
            Console.WriteLine("⚠️ Moeda inválida. Digite apenas: dolar, euro, libra ou iene.");
        }
    }

    if (entradaMoeda == "2")
        break;
}