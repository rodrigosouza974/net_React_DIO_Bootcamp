Uma pilha (*stack*) é uma estrutura de dados que segue o princípio LIFO (Last In, First Out), ou seja, o último elemento a ser inserido é o primeiro a ser removido. Em C#, a classe `Stack<T>` na biblioteca `System.Collections.Generic` oferece uma implementação dessa estrutura.

Aqui está um exemplo básico de como usar uma pilha em C#:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma pilha de inteiros
        Stack<int> pilha = new Stack<int>();

        // Adicionando elementos à pilha
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        // Exibindo o elemento no topo da pilha
        Console.WriteLine("Elemento no topo: " + pilha.Peek());

        // Removendo o elemento do topo da pilha
        Console.WriteLine("Removendo: " + pilha.Pop());

        // Exibindo o elemento no topo após a remoção
        Console.WriteLine("Novo elemento no topo: " + pilha.Peek());

        // Exibindo todos os elementos restantes na pilha
        Console.WriteLine("Elementos na pilha:");
        foreach (int item in pilha)
        {
            Console.WriteLine(item);
        }
    }
}
```

### Explicação:

1. **Criando a pilha:** 
   - `Stack<int> pilha = new Stack<int>();` cria uma pilha de inteiros.

2. **Adicionando elementos:** 
   - `pilha.Push(10);` adiciona o valor `10` ao topo da pilha.
   - Os valores `20` e `30` são adicionados da mesma forma.

3. **Visualizando o topo:** 
   - `pilha.Peek();` retorna o elemento no topo da pilha sem removê-lo.

4. **Removendo o topo:** 
   - `pilha.Pop();` remove e retorna o elemento no topo da pilha.

5. **Iterando pela pilha:** 
   - Um loop `foreach` pode ser usado para percorrer e exibir todos os elementos da pilha.

### Operações com pilhas em .NET:
- `Push(T item)`: Adiciona um item à pilha.
- `Pop()`: Remove e retorna o item do topo.
- `Peek()`: Retorna o item do topo sem removê-lo.
- `Count`: Retorna o número de elementos na pilha.
- `Clear()`: Remove todos os elementos da pilha.

Essas operações são úteis em situações como a execução de algoritmos de backtracking, análise de expressões e implementação de funções recursivas. Se você precisar de uma implementação mais específica ou de um exemplo mais avançado, posso ajudar com isso também.