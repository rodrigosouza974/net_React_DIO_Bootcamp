Em C#, uma tupla (ou "tuple" em inglês) é uma estrutura de dados que pode armazenar um conjunto de valores de diferentes tipos. A tupla é útil quando você precisa retornar múltiplos valores de um método sem precisar criar uma classe específica para isso. As tuplas em C# são imutáveis, ou seja, após a criação, seus valores não podem ser alterados.

### Criando Tuplas
Há duas maneiras de criar tuplas em C#:

1. **Usando a classe `Tuple`**:
   ```csharp
   Tuple<int, string, bool> minhaTupla = new Tuple<int, string, bool>(1, "exemplo", true);
   ```

2. **Usando a sintaxe de tuplas (a partir do C# 7.0)**:
   ```csharp
   var minhaTupla = (1, "exemplo", true);
   ```

### Acessando Valores
Você pode acessar os valores de uma tupla usando as propriedades `Item1`, `Item2`, etc., ou pelos nomes das propriedades, se definidos:

1. **Com a classe `Tuple`**:
   ```csharp
   int numero = minhaTupla.Item1;
   string texto = minhaTupla.Item2;
   bool booleano = minhaTupla.Item3;
   ```

2. **Com a sintaxe de tuplas**:
   ```csharp
   var minhaTupla = (numero: 1, texto: "exemplo", booleano: true);

   int numero = minhaTupla.numero;
   string texto = minhaTupla.texto;
   bool booleano = minhaTupla.booleano;
   ```

### Exemplos de Uso

1. **Retornando múltiplos valores de um método**:
   ```csharp
   (int, int) CalcularSomaEDiferenca(int a, int b)
   {
       return (a + b, a - b);
   }

   var resultado = CalcularSomaEDiferenca(5, 3);
   Console.WriteLine($"Soma: {resultado.Item1}, Diferença: {resultado.Item2}");
   ```

2. **Tuplas com nomes de elementos**:
   ```csharp
   (int soma, int diferenca) CalcularSomaEDiferenca(int a, int b)
   {
       return (a + b, a - b);
   }

   var resultado = CalcularSomaEDiferenca(5, 3);
   Console.WriteLine($"Soma: {resultado.soma}, Diferença: {resultado.diferenca}");
   ```

### Considerações
- **Imutabilidade**: Após criada, você não pode alterar os valores de uma tupla.
- **Performance**: Tuplas são eficientes, mas para grandes conjuntos de dados ou uso intensivo, considere usar uma estrutura de dados mais apropriada.

Tuplas são uma ferramenta poderosa para manipulação de dados simples e ajudam a evitar a necessidade de criar classes temporárias para retornos múltiplos.