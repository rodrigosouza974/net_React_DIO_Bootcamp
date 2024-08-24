Para serializar uma coleção de objetos em um arquivo JSON usando C#, o processo é semelhante ao da serialização de um único objeto, mas você precisa trabalhar com uma coleção (como uma lista) em vez de um único objeto.

Aqui está um exemplo:

### Exemplo de Código

Imagine que você tenha a mesma classe `Produto` e deseja serializar uma lista de produtos.

```csharp
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}

class Program
{
    static void Main()
    {
        // Criando uma lista de produtos
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Cadeira Gamer", Preco = 899.99M },
            new Produto { Id = 2, Nome = "Mouse", Preco = 59.99M },
            new Produto { Id = 3, Nome = "Teclado Mecânico", Preco = 299.99M }
        };

        // Serializando a lista de produtos para JSON
        string jsonString = JsonSerializer.Serialize(produtos, new JsonSerializerOptions { WriteIndented = true });

        // Escrevendo o JSON em um arquivo
        File.WriteAllText("produtos.json", jsonString);

        Console.WriteLine("Lista de produtos salva em JSON com sucesso!");
    }
}
```

### Explicação

1. **Lista de Produtos:** A lista `produtos` é uma coleção de objetos `Produto`.
2. **Serialização:** O método `JsonSerializer.Serialize` converte a lista de produtos em uma string JSON. A opção `WriteIndented = true` é usada para formatar o JSON de maneira legível (com indentação).
3. **Escrita em Arquivo:** O JSON gerado é então salvo em um arquivo chamado `produtos.json` usando `File.WriteAllText`.

### Resultado

Após executar esse código, você terá um arquivo `produtos.json` com o seguinte conteúdo:

```json
[
    {
        "Id": 1,
        "Nome": "Cadeira Gamer",
        "Preco": 899.99
    },
    {
        "Id": 2,
        "Nome": "Mouse",
        "Preco": 59.99
    },
    {
        "Id": 3,
        "Nome": "Teclado Mecânico",
        "Preco": 299.99
    }
]
```

### Nota

Se você precisar serializar diferentes tipos de coleções (por exemplo, arrays ou outras coleções genéricas como `Dictionary`), o processo é basicamente o mesmo. O método `JsonSerializer.Serialize` consegue lidar com a maioria das coleções comuns em C#.