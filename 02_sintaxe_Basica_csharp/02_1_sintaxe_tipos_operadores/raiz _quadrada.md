Para calcular a raiz quadrada em C#, você pode usar o método `Math.Sqrt` da classe `System.Math`. Esse método aceita um número do tipo `double` como argumento e retorna a raiz quadrada desse número.

Aqui está um exemplo de como usar `Math.Sqrt` para calcular a raiz quadrada de um número:

```csharp
using System;

public class SquareRootExample
{
    public static void Main(string[] args)
    {
        double number = 16;
        double result = Math.Sqrt(number);
        
        Console.WriteLine($"A raiz quadrada de {number} é {result}");
    }
}
```

### Explicação

- **`Math.Sqrt(double d)`**: Este método calcula a raiz quadrada de `d`.
- **Entrada**: O número do qual você deseja encontrar a raiz quadrada.
- **Saída**: A raiz quadrada do número de entrada.

### Exemplo Adicional
Aqui está um exemplo mais interativo que permite ao usuário inserir um número e calcular a raiz quadrada desse número:

```csharp
using System;

public class SquareRootInteractiveExample
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número para calcular a raiz quadrada: ");
        string input = Console.ReadLine();
        
        if (double.TryParse(input, out double number))
        {
            double result = Math.Sqrt(number);
            Console.WriteLine($"A raiz quadrada de {number} é {result}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
        }
    }
}
```

### Explicação Detalhada

1. **Entrada do Usuário**: 
   - O programa solicita ao usuário que insira um número.
   - `Console.ReadLine()` lê a entrada do usuário como uma string.

2. **Conversão de String para Double**:
   - `double.TryParse(input, out double number)` tenta converter a string de entrada para um número do tipo `double`.
   - Se a conversão for bem-sucedida, `number` conterá o valor convertido; caso contrário, a conversão falha e o programa informa que a entrada é inválida.

3. **Cálculo da Raiz Quadrada**:
   - `Math.Sqrt(number)` calcula a raiz quadrada do número inserido pelo usuário.

4. **Exibição do Resultado**:
   - O resultado é exibido no console.

5. **Tratamento de Entrada Inválida**:
   - Se a conversão falhar, o programa informa ao usuário que a entrada é inválida e solicita que insira um número válido.

Esses exemplos ilustram como usar `Math.Sqrt` para calcular a raiz quadrada de um número em C#, seja ele um valor fixo no código ou uma entrada fornecida pelo usuário.