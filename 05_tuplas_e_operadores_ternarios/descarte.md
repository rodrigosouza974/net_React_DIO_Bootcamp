Em C#, o conceito de *descartes* geralmente se refere ao uso da palavra-chave `_` para ignorar ou descartar valores retornados por métodos ou expressões, em vez de armazená-los em variáveis. Essa técnica é útil quando você está interessado apenas em parte do resultado de uma operação ou em executar uma operação sem se importar com o valor retornado.

Aqui estão alguns exemplos de como os descartes podem ser usados em C#:

### 1. **Descarte de valores de tuplas**
Se uma função retorna uma tupla, você pode usar o descarte para ignorar os valores que não são necessários.

```csharp
(int x, int y) GetCoordinates()
{
    return (5, 10);
}

void Example()
{
    var (_, y) = GetCoordinates(); // Ignora 'x' e captura apenas 'y'
    Console.WriteLine(y); // Saída: 10
}
```

### 2. **Descarte em padrões de correspondência (pattern matching)**
Você pode usar o descarte em expressões de *pattern matching* para ignorar partes da correspondência que não são importantes.

```csharp
object obj = 42;

if (obj is int _)
{
    Console.WriteLine("É um inteiro, mas não me importo com o valor.");
}
```

### 3. **Descarte de valores de retorno**
Se você está chamando um método que retorna um valor, mas você não precisa desse valor, pode usar o descarte para ignorá-lo.

```csharp
int SomeMethod()
{
    return 42;
}

void Example()
{
    _ = SomeMethod(); // Chama o método, mas ignora o valor retornado
}
```

### 4. **Descarte em out variables**
Você pode usar o descarte com a palavra-chave `out` para ignorar um valor de retorno específico em métodos que usam parâmetros `out`.

```csharp
bool TryParseInt(string input, out int result)
{
    return int.TryParse(input, out result);
}

void Example()
{
    if (TryParseInt("123", out _))
    {
        Console.WriteLine("Parsing bem-sucedido, mas não preciso do valor.");
    }
}
```

Esses exemplos mostram como o descarte é uma técnica poderosa em C# para simplificar o código e focar apenas nas partes que realmente importam.