Para alterar a cultura (localização) de uma aplicação no .NET, você pode modificar a cultura globalmente, afetando como números, datas, horas e valores monetários são formatados em toda a aplicação. Isso pode ser feito usando as propriedades `CurrentCulture` e `CurrentUICulture` da classe `Thread`.

Aqui está um exemplo de como alterar a cultura da aplicação:

### 1. Alterando a Cultura Globalmente

Este exemplo mostra como definir a cultura para português do Brasil (`pt-BR`):

```csharp
using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        // Definindo a cultura global para o thread principal como "pt-BR"
        Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

        // Teste de formatação de número como moeda
        decimal valor = 1234.56m;
        string valorFormatado = valor.ToString("C");
        Console.WriteLine(valorFormatado); // Saída: R$ 1.234,56

        // Teste de formatação de data
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual.ToString("D")); // Saída: quinta-feira, 19 de agosto de 2024
    }
}
```

### 2. Alterando a Cultura para Outro Idioma

Se você deseja alterar para uma cultura diferente, como inglês dos Estados Unidos (`en-US`), você faria o seguinte:

```csharp
using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        // Definindo a cultura global para "en-US"
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

        // Teste de formatação de número como moeda
        decimal valor = 1234.56m;
        string valorFormatado = valor.ToString("C");
        Console.WriteLine(valorFormatado); // Saída: $1,234.56

        // Teste de formatação de data
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine(dataAtual.ToString("D")); // Saída: Monday, August 19, 2024
    }
}
```

### 3. Aplicação Global da Cultura

Se você quiser aplicar essas configurações em todo o sistema, uma abordagem comum é definir a cultura na inicialização da aplicação, como no método `Main` em uma aplicação de console, ou no `Startup` de uma aplicação ASP.NET.

### Considerações

- **`CurrentCulture`**: Controla a formatação de dados como números, datas e moedas.
- **`CurrentUICulture`**: Controla a cultura usada para as interfaces de usuário, como a localização de strings.

Ao definir essas propriedades, você está alterando como todos os elementos da aplicação serão exibidos com base na cultura especificada. Isso é particularmente útil em aplicações multilíngues ou que precisam suportar várias regiões.