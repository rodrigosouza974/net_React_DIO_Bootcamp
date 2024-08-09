Vamos criar uma classe `Calculadora` em C# que inclua métodos para realizar operações aritméticas básicas: adição, subtração, multiplicação, divisão e módulo. Além disso, vamos incluir métodos para incremento e decremento.

Aqui está um exemplo de como essa classe pode ser implementada:

```csharp
using System;

class Calculadora
{
    // Método para adição
    public int Adicionar(int a, int b)
    {
        return a + b;
    }

    // Método para subtração
    public int Subtrair(int a, int b)
    {
        return a - b;
    }

    // Método para multiplicação
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // Método para divisão
    public int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Divisão por zero não é permitida.");
        }
        return a / b;
    }

    // Método para módulo
    public int Modulo(int a, int b)
    {
        return a % b;
    }

    // Método para incremento
    public int Incrementar(int a)
    {
        return ++a;
    }

    // Método para decremento
    public int Decrementar(int a)
    {
        return --a;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();

        int a = 10;
        int b = 5;

        Console.WriteLine("Adição: " + calculadora.Adicionar(a, b));
        Console.WriteLine("Subtração: " + calculadora.Subtrair(a, b));
        Console.WriteLine("Multiplicação: " + calculadora.Multiplicar(a, b));
        Console.WriteLine("Divisão: " + calculadora.Dividir(a, b));
        Console.WriteLine("Módulo: " + calculadora.Modulo(a, b));
        Console.WriteLine("Incremento: " + calculadora.Incrementar(a));
        Console.WriteLine("Decremento: " + calculadora.Decrementar(b));
    }
}
```

Neste exemplo:

- A classe `Calculadora` contém métodos para cada operação aritmética básica.
- Cada método recebe os parâmetros necessários e retorna o resultado da operação.
- No método `Dividir`, há uma verificação para garantir que não ocorra divisão por zero.
- No método `Incrementar`, o valor do parâmetro é incrementado antes de ser retornado.
- No método `Decrementar`, o valor do parâmetro é decrementado antes de ser retornado.

A classe `Program` contém o método `Main`, onde um objeto da classe `Calculadora` é instanciado e os métodos são chamados com valores de exemplo. A saída do programa será exibida no console.