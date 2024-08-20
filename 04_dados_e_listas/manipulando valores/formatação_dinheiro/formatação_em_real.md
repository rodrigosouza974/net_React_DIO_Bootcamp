Para formatar valores monetários em reais (R$) no C# .NET, você pode usar a função `ToString()` com uma cultura específica que suporte o formato de moeda em real brasileiro. O código abaixo mostra como fazer isso:

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal valor = 1234.56m;

        // Formatar como moeda em Real
        string valorFormatado = valor.ToString("C", new CultureInfo("pt-BR"));

        Console.WriteLine(valorFormatado); // Saída: R$ 1.234,56
    }
}
```

### Explicação:
- **`decimal valor = 1234.56m;`**: Define um valor decimal que você deseja formatar.
- **`ToString("C", new CultureInfo("pt-BR"));`**: O `"C"` indica que você quer formatar o número como moeda. `new CultureInfo("pt-BR")` especifica a cultura brasileira, que usa o símbolo `R$` e o formato de moeda brasileiro.
  
Essa abordagem garante que o valor seja formatado corretamente como real brasileiro, incluindo o símbolo `R$` e o uso de vírgula como separador decimal.


Quando seu professor mencionou o uso de `:c` para formatar valores como moeda em C#, ele estava se referindo a uma forma mais simples de formatar strings, frequentemente utilizada dentro de interpolação de strings. Aqui está um exemplo:

```csharp
using System;

class Program
{
    static void Main()
    {
        decimal valor = 1234.56m;

        // Usando interpolação de strings com ":c"
        string valorFormatado = $"{valor:c}";

        Console.WriteLine(valorFormatado); // Saída: R$ 1.234,56
    }
}
```

### Explicação:
- **`$"{valor:c}"`**: Esse é o formato de interpolação de strings no C#. O `$` permite inserir variáveis diretamente dentro da string. O `:c` depois da variável `valor` indica que ele deve ser formatado como moeda (currency), o que utiliza o formato de moeda padrão do sistema operacional, que no Brasil seria `R$`.

Se o sistema estiver configurado para a cultura brasileira (`pt-BR`), essa interpolação formatará automaticamente o valor como `R$ 1.234,56`. Se estiver em outra cultura, o símbolo de moeda será o correspondente ao padrão da localidade configurada no sistema. Se você quiser garantir que sempre seja formatado em reais, pode combinar com a `CultureInfo`:

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal valor = 1234.56m;

        // Forçando a cultura "pt-BR" na interpolação
        string valorFormatado = $"{valor.ToString("c", new CultureInfo("pt-BR"))}";

        Console.WriteLine(valorFormatado); // Saída: R$ 1.234,56
    }
}
```

Essa última abordagem garante que, independentemente da configuração de cultura do sistema, o valor seja formatado como real brasileiro (`R$`).