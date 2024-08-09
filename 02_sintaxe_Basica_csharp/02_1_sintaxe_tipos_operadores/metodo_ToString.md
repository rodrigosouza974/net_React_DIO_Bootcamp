Em C#, o método `ToString()` é amplamente utilizado para converter um objeto em sua representação de string. Esse método é definido na classe base `Object`, então está disponível para todas as classes em C#. Aqui estão alguns exemplos comuns de uso do `ToString()`:

### Exemplos de Uso do `ToString()`

1. **Conversão Simples de Tipos Primitivos:**

   ```csharp
   int number = 123;
   string numberString = number.ToString();
   Console.WriteLine($"Número como string: {numberString}");

   double pi = 3.14159;
   string piString = pi.ToString();
   Console.WriteLine($"Pi como string: {piString}");
   ```

2. **Formatação de String:**

   Você pode passar um argumento de formatação para o `ToString()` para formatar a string resultante.

   ```csharp
   double amount = 1234.56;
   string formattedAmount = amount.ToString("C"); // Formata como moeda
   Console.WriteLine($"Valor formatado: {formattedAmount}");

   DateTime now = DateTime.Now;
   string formattedDate = now.ToString("yyyy-MM-dd");
   Console.WriteLine($"Data formatada: {formattedDate}");
   ```

3. **Objetos Personalizados:**

   Para classes personalizadas, você pode substituir o método `ToString()` para fornecer uma representação de string mais significativa do objeto.

   ```csharp
   public class Person
   {
       public string FirstName { get; set; }
       public string LastName { get; set; }

       public override string ToString()
       {
           return $"{FirstName} {LastName}";
       }
   }

   class Program
   {
       static void Main()
       {
           Person person = new Person { FirstName = "John", LastName = "Doe" };
           Console.WriteLine(person.ToString()); // Saída: John Doe
       }
   }
   ```

### Exemplo Completo

Aqui está um exemplo completo que demonstra o uso de `ToString()` com diferentes tipos de dados e formatação:

```csharp
using System;

class Program
{
    static void Main()
    {
        // Convertendo int para string
        int number = 123;
        string numberString = number.ToString();
        Console.WriteLine($"Número como string: {numberString}");

        // Convertendo double para string com formatação
        double pi = 3.14159;
        string piString = pi.ToString("F2"); // Formata com 2 casas decimais
        Console.WriteLine($"Pi como string: {piString}");

        // Convertendo DateTime para string com formatação
        DateTime now = DateTime.Now;
        string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
        Console.WriteLine($"Data e hora formatadas: {formattedDate}");

        // Convertendo valor monetário para string com formatação
        double amount = 1234.56;
        string formattedAmount = amount.ToString("C"); // Formata como moeda
        Console.WriteLine($"Valor formatado: {formattedAmount}");

        // Usando ToString() em uma classe personalizada
        Person person = new Person { FirstName = "John", LastName = "Doe" };
        Console.WriteLine(person.ToString()); // Saída: John Doe
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
```

Neste exemplo, demonstramos como o método `ToString()` pode ser usado para converter números, datas e objetos personalizados em suas representações de string, bem como para formatar essas strings de várias maneiras.