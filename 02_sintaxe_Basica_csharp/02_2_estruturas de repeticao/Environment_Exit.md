Em C#, para sair de um programa ou encerrar a execução de um método, você pode usar o método `Environment.Exit()`. Aqui está um exemplo simples de como utilizá-lo:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando o programa...");

        // Sua lógica de código aqui
        
        // Sair do programa com código de saída 0 (sem erros)
        Environment.Exit(0);
        
        // Código após Environment.Exit não será executado
        Console.WriteLine("Este texto não será exibido.");
    }
}
```

No exemplo acima, `Environment.Exit(0)` é chamado para sair do programa. O parâmetro `0` indica que o programa terminou sem erros. Você pode usar outros códigos de saída para indicar diferentes tipos de término do programa, como `Environment.Exit(1)` para indicar que ocorreu um erro.

Se precisar de mais alguma coisa sobre C# ou qualquer outro assunto, estou aqui para ajudar!