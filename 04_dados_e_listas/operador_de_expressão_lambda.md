O operador `=>` em C# é conhecido como o **operador de expressão lambda** ou **sintaxe de expressão**. Ele é utilizado para criar funções anônimas ou expressões lambda e também é usado em propriedades e métodos de uma única linha para simplificar a definição de membros.

### Exemplos de Uso do Operador `=>`

1. **Expressões Lambda**
   - Expressões lambda permitem criar funções anônimas (funções sem nome) que podem ser usadas para passar blocos de código como argumentos para métodos como `LINQ`, `Delegates`, etc.
   ```csharp
   Func<int, int> quadrado = x => x * x;

   int resultado = quadrado(5);  // Resultado será 25
   ```

   Neste exemplo, `x => x * x` é uma expressão lambda que recebe um parâmetro `x` e retorna o quadrado desse valor.

2. **Propriedades de Expressão**
   - O operador `=>` pode ser usado para definir propriedades de forma concisa.
   ```csharp
   public class Pessoa
   {
       public string Nome { get; set; }
       public string Sobrenome { get; set; }

       // Propriedade somente leitura que usa uma expressão
       public string NomeCompleto => $"{Nome} {Sobrenome}";
   }
   ```

   Aqui, `NomeCompleto => $"{Nome} {Sobrenome}"` é uma propriedade que retorna o nome completo da pessoa.

3. **Métodos de Expressão**
   - Similarmente, você pode usar o operador `=>` para métodos que possuem apenas uma linha de código.
   ```csharp
   public class Calculadora
   {
       public int Somar(int a, int b) => a + b;
   }
   ```

   Neste exemplo, o método `Somar` usa a sintaxe de expressão para retornar a soma de `a` e `b`.

### Benefícios do Operador `=>`

- **Conciso e Limpo:** Torna o código mais curto e fácil de ler, especialmente para métodos simples e propriedades calculadas.
- **Expressivo:** Melhora a clareza do código ao expressar a lógica de maneira direta, especialmente em operações que se encaixam em uma única linha.

O operador `=>` é uma poderosa ferramenta em C# para simplificar a definição de métodos, propriedades e funções anônimas.