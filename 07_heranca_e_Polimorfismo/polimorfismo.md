O polimorfismo é um conceito fundamental na programação orientada a objetos (OOP) e está intimamente ligado à herança e à sobrecarga de métodos. Em C#, o polimorfismo permite que objetos de diferentes classes sejam tratados como objetos de uma classe base comum. Isso facilita o uso de métodos comuns, enquanto permite que cada classe forneça sua própria implementação desses métodos.

### Tipos de Polimorfismo

1. **Polimorfismo em Tempo de Compilação (Estático):**
   - **Sobrecarga de Métodos:** Múltiplos métodos com o mesmo nome, mas com diferentes parâmetros, dentro da mesma classe.
   - **Sobrecarga de Operadores:** Definição de comportamentos personalizados para operadores.

2. **Polimorfismo em Tempo de Execução (Dinâmico):**
   - **Sobrescrita de Métodos:** Permite que uma classe derivada forneça uma implementação específica de um método que já existe na classe base. Isso é feito usando a palavra-chave `override`.

### Exemplo de Polimorfismo em Tempo de Execução

A seguir, um exemplo de como o polimorfismo em tempo de execução funciona em C#:

```csharp
// Classe base
public class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

// Classe derivada
public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}

// Classe derivada
public class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia.");
    }
}

// Utilizando o polimorfismo
class Program
{
    static void Main()
    {
        Animal meuAnimal;

        // Cachorro
        meuAnimal = new Cachorro();
        meuAnimal.FazerSom();  // Saída: O cachorro late.

        // Gato
        meuAnimal = new Gato();
        meuAnimal.FazerSom();  // Saída: O gato mia.
    }
}
```

### Explicação do Exemplo

- **Classe Base `Animal`:** Contém o método `FazerSom`, marcado como `virtual`, o que permite que ele seja sobrescrito em classes derivadas.
- **Classe `Cachorro` e `Gato`:** Ambas derivam de `Animal` e sobrescrevem o método `FazerSom` com suas próprias implementações.
- **Polimorfismo em Ação:** Em tempo de execução, o método `FazerSom` é chamado de acordo com o tipo de objeto para o qual a variável `meuAnimal` está apontando, mesmo que `meuAnimal` seja do tipo `Animal`. Isso demonstra o poder do polimorfismo dinâmico.

### Polimorfismo em Tempo de Compilação (Sobrecarga de Métodos)

Aqui está um exemplo de sobrecarga de métodos, que é um tipo de polimorfismo em tempo de compilação:

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine(calc.Somar(2, 3));           // Saída: 5
        Console.WriteLine(calc.Somar(2.5, 3.7));       // Saída: 6.2
        Console.WriteLine(calc.Somar(1, 2, 3));        // Saída: 6
    }
}
```

### Explicação do Exemplo

- **Sobrecarga de Métodos:** A classe `Calculadora` possui três métodos `Somar`, cada um com uma assinatura diferente. Isso permite que você chame `Somar` com diferentes tipos e números de argumentos, e o compilador determinará qual método específico chamar.

### Conclusão

O polimorfismo em C# oferece flexibilidade e extensibilidade ao código, permitindo que métodos tenham múltiplas formas e comportamentos dependendo do contexto. Enquanto o polimorfismo em tempo de compilação (sobrecarga) se baseia em diferentes assinaturas de métodos, o polimorfismo em tempo de execução (sobrescrita) permite que subclasses personalizem o comportamento de métodos da classe base. Isso facilita a criação de sistemas escaláveis e reutilizáveis, onde novas classes podem ser adicionadas sem alterar o código existente.