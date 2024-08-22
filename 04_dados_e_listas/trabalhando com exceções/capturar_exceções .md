Para tratar erros no .NET, você pode usar blocos `try`, `catch`, e opcionalmente `finally`. Esses blocos permitem capturar exceções (erros) que possam ocorrer durante a execução de um código e tratá-las de forma adequada.

Aqui está um exemplo básico de como usar `try` e `catch` para tratar erros e exibir a mensagem da exceção:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Código que pode gerar uma exceção
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // Isso vai gerar uma exceção
        }
        catch (IndexOutOfRangeException ex)
        {
            // Tratamento da exceção
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
        finally
        {
            // Código que sempre será executado, independentemente de uma exceção ter sido lançada ou não
            Console.WriteLine("Finalizando o bloco try-catch.");
        }
    }
}
```

### Explicação:

- **`try`**: O bloco `try` contém o código que pode lançar uma exceção. Se a exceção ocorrer, o controle é passado imediatamente para o bloco `catch`.

- **`catch`**: O bloco `catch` captura a exceção e permite que você trate o erro. Neste exemplo, ele captura a exceção do tipo `IndexOutOfRangeException` e exibe a mensagem de erro usando `ex.Message`.

- **`finally`** (opcional): O bloco `finally` contém código que sempre será executado, independentemente de uma exceção ter ocorrido ou não. Ele é útil para liberar recursos, como fechar arquivos ou conexões de banco de dados.

Ao usar `try-catch`, você pode garantir que seu programa continue funcionando corretamente, mesmo quando ocorrem erros inesperados.