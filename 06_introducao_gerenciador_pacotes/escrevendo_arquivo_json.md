Para escrever em um arquivo JSON em C#, você pode utilizar a biblioteca `System.Text.Json`, que faz parte do .NET Core. Vou te mostrar um exemplo simples de como fazer isso.

### Passo a Passo

1. **Crie uma classe** que represente a estrutura dos dados que você deseja salvar em JSON.
2. **Serialize o objeto** para JSON utilizando a classe `JsonSerializer`.
3. **Escreva o JSON** em um arquivo.

### Exemplo de Código

Suponha que você tenha uma classe `Produto`:

```csharp
using System;
using System.Text.Json;
using System.IO;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}
```

Agora, para salvar um objeto `Produto` em um arquivo JSON, você faria o seguinte:

```csharp
class Program
{
    static void Main()
    {
        Produto produto = new Produto
        {
            Id = 1,
            Nome = "Cadeira Gamer",
            Preco = 899.99M
        };

        // Serializar o objeto para JSON
        string jsonString = JsonSerializer.Serialize(produto);

        // Escrever o JSON em um arquivo
        File.WriteAllText("produto.json", jsonString);

        Console.WriteLine("Produto salvo em JSON com sucesso!");
    }
}
```

### Explicação

1. **Serialização:** O método `JsonSerializer.Serialize` converte o objeto `Produto` em uma string JSON.
2. **Escrita em Arquivo:** O método `File.WriteAllText` escreve essa string JSON em um arquivo chamado `produto.json`.

### Resultado

Após executar esse código, você terá um arquivo `produto.json` criado no mesmo diretório do projeto com o seguinte conteúdo:

```json
{
    "Id": 1,
    "Nome": "Cadeira Gamer",
    "Preco": 899.99
}
```

Esse é o básico para começar a escrever arquivos JSON em C#. Se precisar de mais funcionalidades, como escrever uma lista de objetos ou trabalhar com formatação personalizada, você pode ajustar o código.