Formatar um `DateTime` em C# é uma tarefa comum, especialmente quando você precisa exibir datas e horas em um formato específico. A classe `DateTime` oferece vários métodos para formatação, sendo o método `ToString()` o mais usado. Aqui estão algumas maneiras de formatar datas e horas em C#:

### 1. Usando `DateTime.ToString()`

O método `ToString()` permite que você formate um `DateTime` usando diferentes padrões de formatação.

#### Exemplos de Formatação:

```csharp
using System;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        // Formatos comuns de data e hora
        string formatoCompleto = dataAtual.ToString("F");    // Exemplo: segunda-feira, 19 de agosto de 2024 14:45:30
        string formatoCurto = dataAtual.ToString("g");       // Exemplo: 19/08/2024 14:45
        string apenasData = dataAtual.ToString("d");         // Exemplo: 19/08/2024
        string apenasHora = dataAtual.ToString("t");         // Exemplo: 14:45

        // Formato customizado
        string formatoCustomizado = dataAtual.ToString("dd-MM-yyyy HH:mm:ss"); // Exemplo: 19-08-2024 14:45:30

        Console.WriteLine(formatoCompleto);
        Console.WriteLine(formatoCurto);
        Console.WriteLine(apenasData);
        Console.WriteLine(apenasHora);
        Console.WriteLine(formatoCustomizado);
    }
}
```

### 2. Usando Padrões de Formatação Predefinidos

C# fornece várias strings de formatação predefinidas para `DateTime`, como:

- **`"d"`**: Data curta (ex: `19/08/2024`)
- **`"D"`**: Data longa (ex: `segunda-feira, 19 de agosto de 2024`)
- **`"f"`**: Data longa com hora curta (ex: `segunda-feira, 19 de agosto de 2024 14:45`)
- **`"F"`**: Data e hora completas (ex: `segunda-feira, 19 de agosto de 2024 14:45:30`)
- **`"g"`**: Data e hora curtas (ex: `19/08/2024 14:45`)
- **`"G"`**: Data curta com hora completa (ex: `19/08/2024 14:45:30`)
- **`"t"`**: Hora curta (ex: `14:45`)
- **`"T"`**: Hora longa (ex: `14:45:30`)
- **`"R"`**: Data e hora em formato RFC1123 (ex: `Mon, 19 Aug 2024 14:45:30 GMT`)

### 3. Formatação Customizada

Você pode criar formatos customizados usando componentes de data e hora:

- **`dd`**: Dia do mês (com dois dígitos, 01-31)
- **`MM`**: Mês (com dois dígitos, 01-12)
- **`yyyy`**: Ano (com quatro dígitos)
- **`HH`**: Hora no formato 24 horas (com dois dígitos, 00-23)
- **`mm`**: Minutos (com dois dígitos, 00-59)
- **`ss`**: Segundos (com dois dígitos, 00-59)
- **`tt`**: AM/PM

Exemplo de formatação customizada:

```csharp
using System;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        // Exemplo de formatação customizada
        string formatoCustomizado = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");
        Console.WriteLine(formatoCustomizado); // Exemplo de saída: 19/08/2024 14:45:30
    }
}
```

### 4. Usando `CultureInfo` para Formatação Localizada

Se você precisar formatar uma data de acordo com uma cultura específica, use o `CultureInfo`:

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        // Exemplo de formatação em português do Brasil
        string formatoBrasil = dataAtual.ToString("D", new CultureInfo("pt-BR"));
        Console.WriteLine(formatoBrasil); // Exemplo de saída: segunda-feira, 19 de agosto de 2024

        // Exemplo de formatação em inglês dos EUA
        string formatoEUA = dataAtual.ToString("D", new CultureInfo("en-US"));
        Console.WriteLine(formatoEUA); // Exemplo de saída: Monday, August 19, 2024
    }
}
```

Dessa forma, você pode garantir que a data e a hora sejam exibidas de maneira apropriada para a cultura ou o formato desejado.