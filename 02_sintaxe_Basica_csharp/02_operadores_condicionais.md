Em C#, operadores condicionais são usados para tomar decisões baseadas em condições específicas. Aqui estão os principais operadores condicionais:

### Operadores de Comparação

Estes operadores comparam dois valores e retornam um valor booleano (`true` ou `false`):

1. `==` (igual a)
2. `!=` (diferente de)
3. `>` (maior que)
4. `<` (menor que)
5. `>=` (maior ou igual a)
6. `<=` (menor ou igual a)

### Operadores Lógicos

Estes operadores combinam múltiplas condições booleanas:

1. `&&` (AND lógico) - Retorna `true` se ambas as condições forem verdadeiras.
2. `||` (OR lógico) - Retorna `true` se pelo menos uma das condições for verdadeira.
3. `!` (NOT lógico) - Inverte o valor booleano.

### Operador Condicional Ternário

O operador ternário é uma forma concisa de escrever uma condição `if-else`:

```csharp
condition ? consequent : alternative;
```

### Exemplos

#### Uso de Operadores de Comparação

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        // Operadores de comparação
        Console.WriteLine(a == b);  // False
        Console.WriteLine(a != b);  // True
        Console.WriteLine(a > b);   // False
        Console.WriteLine(a < b);   // True
        Console.WriteLine(a >= b);  // False
        Console.WriteLine(a <= b);  // True
    }
}
```

#### Uso de Operadores Lógicos

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        bool c = true;

        // Operadores lógicos
        Console.WriteLine((a < b) && c);  // True
        Console.WriteLine((a > b) || c);  // True
        Console.WriteLine(!c);            // False
    }
}
```

#### Uso do Operador Condicional Ternário

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        // Operador ternário
        string result = (a > b) ? "a é maior que b" : "a não é maior que b";
        Console.WriteLine(result);  // "a não é maior que b"
    }
}
```

### Condicionais com `if-else`

Além dos operadores condicionais, o C# usa instruções `if`, `else if`, e `else` para controle de fluxo baseado em condições.

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        if (a > b)
        {
            Console.WriteLine("a é maior que b");
        }
        else if (a < b)
        {
            Console.WriteLine("a é menor que b");
        }
        else
        {
            Console.WriteLine("a é igual a b");
        }
    }
}
```

Esses operadores e estruturas condicionais são fundamentais para a lógica de programação em C#, permitindo a execução de código com base em diferentes condições.