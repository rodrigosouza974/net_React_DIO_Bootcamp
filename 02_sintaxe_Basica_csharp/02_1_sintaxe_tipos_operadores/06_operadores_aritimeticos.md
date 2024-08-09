Em C#, os operadores aritméticos são usados para realizar operações matemáticas básicas. Aqui está uma lista dos operadores aritméticos em C# com exemplos:

1. **Adição (+)**:
   - Soma de dois números.
   - Exemplo:
     ```csharp
     int a = 5;
     int b = 3;
     int sum = a + b; // sum = 8
     ```

2. **Subtração (-)**:
   - Subtração de um número pelo outro.
   - Exemplo:
     ```csharp
     int a = 5;
     int b = 3;
     int difference = a - b; // difference = 2
     ```

3. **Multiplicação (*)**:
   - Multiplicação de dois números.
   - Exemplo:
     ```csharp
     int a = 5;
     int b = 3;
     int product = a * b; // product = 15
     ```

4. **Divisão (/)**:
   - Divisão de um número pelo outro.
   - Exemplo:
     ```csharp
     int a = 6;
     int b = 3;
     int quotient = a / b; // quotient = 2
     ```

5. **Módulo (%)**:
   - Resto da divisão de um número pelo outro.
   - Exemplo:
     ```csharp
     int a = 5;
     int b = 3;
     int remainder = a % b; // remainder = 2
     ```

6. **Incremento (++)**:
   - Incrementa o valor de uma variável em 1.
   - Exemplo:
     ```csharp
     int a = 5;
     a++; // a = 6
     ```

7. **Decremento (--)**:
   - Decrementa o valor de uma variável em 1.
   - Exemplo:
     ```csharp
     int a = 5;
     a--; // a = 4
     ```

Aqui estão exemplos mais completos para você entender como esses operadores são usados no contexto de um programa C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // Adição
        int sum = a + b;
        Console.WriteLine("Adição: " + sum);

        // Subtração
        int difference = a - b;
        Console.WriteLine("Subtração: " + difference);

        // Multiplicação
        int product = a * b;
        Console.WriteLine("Multiplicação: " + product);

        // Divisão
        int quotient = a / b;
        Console.WriteLine("Divisão: " + quotient);

        // Módulo
        int remainder = a % b;
        Console.WriteLine("Módulo: " + remainder);

        // Incremento
        a++;
        Console.WriteLine("Incremento: " + a);

        // Decremento
        b--;
        Console.WriteLine("Decremento: " + b);
    }
}
```

Ao executar este programa, você verá a saída das operações aritméticas básicas.

