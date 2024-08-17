Em C#, você pode realizar validações ao definir valores para as propriedades de um objeto usando os métodos `get` e `set`. Isso permite que você controle como os dados são atribuídos às propriedades e garante que eles atendam a certos critérios antes de serem aceitos.

### Exemplo Simples de Validação com `get` e `set`

Aqui está um exemplo de como fazer validações usando `get` e `set` em uma classe:

```csharp
public class Pessoa
{
    private string nome;
    private int idade;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio ou apenas espaços em branco.");
            }
            nome = value;
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0 || value > 120)
            {
                throw new ArgumentOutOfRangeException("A idade deve estar entre 0 e 120.");
            }
            idade = value;
        }
    }
}
```

### Explicação

- **Propriedade `Nome`:**
  - O `set` verifica se o valor atribuído é nulo, vazio ou contém apenas espaços em branco. Se a condição for verdadeira, uma exceção `ArgumentException` é lançada.
  - O `get` simplesmente retorna o valor armazenado na variável privada `nome`.

- **Propriedade `Idade`:**
  - O `set` valida se a idade está dentro do intervalo aceitável (0 a 120). Se não estiver, uma exceção `ArgumentOutOfRangeException` é lançada.
  - O `get` retorna o valor armazenado na variável privada `idade`.

### Exemplo com `Auto-Implemented Properties`

Em C#, você também pode realizar validações em propriedades automáticas usando um campo `backing field` (campo de suporte) explicitamente:

```csharp
public class Produto
{
    private decimal preco;

    public string Nome { get; set; }

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("O preço não pode ser negativo.");
            }
            preco = value;
        }
    }
}
```

### Validação e Encapsulamento

Usar `get` e `set` com validação melhora o encapsulamento em C#, pois você controla como as propriedades do objeto são acessadas e modificadas. Isso é essencial para manter a integridade dos dados dentro de um objeto.

### Propriedades Somente Leitura

Se você deseja que uma propriedade seja somente leitura e ainda quer fazer alguma validação ao definir o valor (por exemplo, apenas no construtor), você pode omitir o `set`:

```csharp
public class Usuario
{
    public string Email { get; }

    public Usuario(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("O e-mail não pode ser vazio.");
        }

        Email = email;
    }
}
```

Nesse exemplo, a propriedade `Email` só pode ser definida no construtor e é somente leitura fora da classe.