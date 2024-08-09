Em C#, `public void` é usado para declarar um método que é acessível de fora da classe onde ele está definido e que não retorna nenhum valor. Vamos dividir isso em duas partes:

1. **public**: Este é um modificador de acesso que torna o método acessível de qualquer lugar. Qualquer código, seja dentro ou fora da classe, pode chamar esse método.

2. **void**: Este é um tipo de retorno que indica que o método não retorna nenhum valor. O método pode executar operações ou procedimentos, mas quando ele termina, não há nenhum valor sendo retornado ao chamador.

Aqui está um exemplo simples para ilustrar:

```csharp
using System;

public class Example
{
    // Declaração de um método público que não retorna valor
    public void ShowMessage()
    {
        // Corpo do método
        Console.WriteLine("Olá, mundo!");
    }

    public static void Main(string[] args)
    {
        // Criando uma instância da classe Example
        Example example = new Example();
        
        // Chamando o método ShowMessage
        example.ShowMessage();
    }
}
```

Neste exemplo:

- **public**: O método `ShowMessage` pode ser chamado de fora da classe `Example`.
- **void**: O método `ShowMessage` não retorna nenhum valor. Ele apenas executa uma ação, que neste caso é imprimir "Olá, mundo!" no console.

Se o método tivesse que retornar um valor, o tipo de retorno seria especificado no lugar de `void`. Por exemplo, se o método tivesse que retornar um número inteiro, ele seria declarado como `public int`:

```csharp
public int GetNumber()
{
    return 42;
}
```

Aqui, `public int GetNumber()` declara um método público que retorna um valor inteiro.