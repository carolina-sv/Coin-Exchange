# 💱 CoinExchange - Currency Converter CLI in C#

A simple and interactive console application to convert Brazilian Reais (BRL) to major foreign currencies using fixed exchange rates.

> 📌 Built in pure C#, designed for clarity, input validation, and clean user experience.

---

## ✨ Features

- 💵 Converts BRL to **USD**, **EUR**, **GBP**, and **JPY**
- ✅ Input validation and helpful error messages
- 🔄 Infinite loop for multiple conversions, with an option to exit
- 🧠 Modular helper class (`ConvertFunction`) for currency conversion
- 🧼 Clean and readable code with clear prompts and emoji feedback

---

## 💸 Supported Currencies

| Currency | Code  | Emoji | Rate (BRL → Currency) |
|----------|-------|-------|------------------------|
| Dollar   | USD   | 💵    | 5.54                   |
| Euro     | EUR   | 💶    | 6.36                   |
| Pound    | GBP   | 💷    | 7.50                   |
| Yen      | JPY   | 💴    | 26.13                  |

---

## 🧠 How It Works

1. The user is prompted to input a value in BRL.
2. Input is validated (must be a number between 0 and 100,000).
3. The user selects a target currency.
4. The converted amount is displayed.
5. The process repeats until the user types `sair` or selects option `2`.

---

## 🧱 Project Structure

```
CoinExchange/
├── Program.cs   
├── Helper/
│   └── ConvertFunction.cs  # Conversion helper method
```

---

## 🖥️ Example Usage

```bash
Enter the amount in BRL 
or type 'sair' to exit:
> 100

✅ You entered R$ 100.00

Which currency do you want to convert to?
Type: 💵 dolar | 💶 euro | 💷 libra | 💴 iene
> dolar

💵 In Dollar: $18.05
```

---

## 🚀 Getting Started

### 🛠 Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)

### ▶️ Run the App

```bash
dotnet run
```

---

## 🔧 ConvertFunction.cs

This helper class performs the actual currency conversion:

```csharp
public class ConvertFunction
{
    public double ConverterMoeda(double amount, double rate)
    {
        return amount / rate;
    }
}
```

---


## 👤 Author

Developed by [Carolina Viana]  
Feel free to open issues or contribute to this project!
